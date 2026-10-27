using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093C RID: 2364
	[NetMessage(EMessageId.LoadEquipInfoRequest)]
	public sealed class LoadEquipInfoRequest : IMessage<LoadEquipInfoRequest>, IMessage, IEquatable<LoadEquipInfoRequest>, IDeepCloneable<LoadEquipInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D050 RID: 53328 RVA: 0x001EA81E File Offset: 0x001E8A1E
		[NullableContext(1)]
		public static LoadEquipInfoRequest Create()
		{
			return new LoadEquipInfoRequest();
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600D051 RID: 53329 RVA: 0x001EA825 File Offset: 0x001E8A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600D052 RID: 53330 RVA: 0x001EA828 File Offset: 0x001E8A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadEquipInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x001EA82F File Offset: 0x001E8A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest()
		{
		}

		// Token: 0x0600D054 RID: 53332 RVA: 0x001EA837 File Offset: 0x001E8A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest(LoadEquipInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x001EA850 File Offset: 0x001E8A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest Clone()
		{
			return new LoadEquipInfoRequest(this);
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x001EA858 File Offset: 0x001E8A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadEquipInfoRequest);
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x001EA866 File Offset: 0x001E8A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadEquipInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D058 RID: 53336 RVA: 0x001EA884 File Offset: 0x001E8A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D059 RID: 53337 RVA: 0x001EA8AA File Offset: 0x001E8AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x001EA8B7 File Offset: 0x001E8AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D05B RID: 53339 RVA: 0x001EA8C0 File Offset: 0x001E8AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D05C RID: 53340 RVA: 0x001EA8D8 File Offset: 0x001E8AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x001EA8FE File Offset: 0x001E8AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadEquipInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D05E RID: 53342 RVA: 0x001EA91B File Offset: 0x001E8B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x001EA924 File Offset: 0x001E8B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057C3 RID: 22467
		private UnknownFieldSet _unknownFields;
	}
}
