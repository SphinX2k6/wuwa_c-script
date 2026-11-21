using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x02000278 RID: 632
	internal sealed class FileBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x06002E25 RID: 11813 RVA: 0x00094160 File Offset: 0x00092360
		public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
			this._mediator = mediator;
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00094170 File Offset: 0x00092370
		public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists)
		{
			ResourceSet result = null;
			string resourceFileName = this._mediator.GetResourceFileName(culture);
			string text = this.FindResourceFile(culture, resourceFileName);
			if (text == null)
			{
				if (tryParents && culture.HasInvariantCultureName)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 4);
					defaultInterpolatedStringHandler.AppendFormatted(SR.MissingManifestResource_NoNeutralDisk);
					defaultInterpolatedStringHandler.AppendFormatted("\r\n");
					defaultInterpolatedStringHandler.AppendLiteral("baseName: ");
					defaultInterpolatedStringHandler.AppendFormatted(this._mediator.BaseNameField);
					defaultInterpolatedStringHandler.AppendLiteral("  fileName: ");
					defaultInterpolatedStringHandler.AppendFormatted(this._mediator.GetResourceFileName(culture));
					throw new MissingManifestResourceException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			else
			{
				result = this.CreateResourceSet(text);
			}
			return result;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00094218 File Offset: 0x00092418
		private string FindResourceFile(CultureInfo culture, string fileName)
		{
			if (this._mediator.ModuleDir != null)
			{
				string text = Path.Combine(this._mediator.ModuleDir, fileName);
				if (File.Exists(text))
				{
					return text;
				}
			}
			if (File.Exists(fileName))
			{
				return fileName;
			}
			return null;
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0009425C File Offset: 0x0009245C
		private ResourceSet CreateResourceSet(string file)
		{
			if (this._mediator.UserResourceSet == null)
			{
				return new RuntimeResourceSet(file);
			}
			object[] args = new object[]
			{
				file
			};
			ResourceSet result;
			try
			{
				result = (ResourceSet)Activator.CreateInstance(this._mediator.UserResourceSet, args);
			}
			catch (MissingMethodException innerException)
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResMgrBadResSet_Type, this._mediator.UserResourceSet.AssemblyQualifiedName), innerException);
			}
			return result;
		}

		// Token: 0x0400086D RID: 2157
		private readonly ResourceManager.ResourceManagerMediator _mediator;
	}
}
