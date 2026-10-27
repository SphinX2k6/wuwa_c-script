using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093A RID: 2362
	[NetMessage(EMessageId.LoadCalabashSkinInfoRequest)]
	public sealed class LoadCalabashSkinInfoRequest : IMessage<LoadCalabashSkinInfoRequest>, IMessage, IEquatable<LoadCalabashSkinInfoRequest>, IDeepCloneable<LoadCalabashSkinInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D02A RID: 53290 RVA: 0x001EA37B File Offset: 0x001E857B
		[NullableContext(1)]
		public static LoadCalabashSkinInfoRequest Create()
		{
			return new LoadCalabashSkinInfoRequest();
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600D02B RID: 53291 RVA: 0x001EA382 File Offset: 0x001E8582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0600D02C RID: 53292 RVA: 0x001EA385 File Offset: 0x001E8585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadCalabashSkinInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x001EA38C File Offset: 0x001E858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest()
		{
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x001EA394 File Offset: 0x001E8594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest(LoadCalabashSkinInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D02F RID: 53295 RVA: 0x001EA3AD File Offset: 0x001E85AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest Clone()
		{
			return new LoadCalabashSkinInfoRequest(this);
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x001EA3B5 File Offset: 0x001E85B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadCalabashSkinInfoRequest);
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x001EA3C3 File Offset: 0x001E85C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadCalabashSkinInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D032 RID: 53298 RVA: 0x001EA3E4 File Offset: 0x001E85E4
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

		// Token: 0x0600D033 RID: 53299 RVA: 0x001EA40A File Offset: 0x001E860A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x001EA417 File Offset: 0x001E8617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D035 RID: 53301 RVA: 0x001EA420 File Offset: 0x001E8620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x001EA438 File Offset: 0x001E8638
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

		// Token: 0x0600D037 RID: 53303 RVA: 0x001EA45E File Offset: 0x001E865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadCalabashSkinInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x001EA47B File Offset: 0x001E867B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x001EA484 File Offset: 0x001E8684
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

		// Token: 0x040057BA RID: 22458
		private UnknownFieldSet _unknownFields;
	}
}
