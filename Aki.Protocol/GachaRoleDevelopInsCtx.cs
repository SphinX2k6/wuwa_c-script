using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A1 RID: 1697
	public sealed class GachaRoleDevelopInsCtx : IMessage<GachaRoleDevelopInsCtx>, IMessage, IEquatable<GachaRoleDevelopInsCtx>, IDeepCloneable<GachaRoleDevelopInsCtx>, IBufferMessage
	{
		// Token: 0x06009B52 RID: 39762 RVA: 0x00176B83 File Offset: 0x00174D83
		[NullableContext(1)]
		public static GachaRoleDevelopInsCtx Create()
		{
			return new GachaRoleDevelopInsCtx();
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06009B53 RID: 39763 RVA: 0x00176B8A File Offset: 0x00174D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x00176B8D File Offset: 0x00174D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRoleDevelopInsCtx.Descriptor;
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x00176B94 File Offset: 0x00174D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx()
		{
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x00176B9C File Offset: 0x00174D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx(GachaRoleDevelopInsCtx other) : this()
		{
			this.gachaRoleDevelopInsId_ = other.gachaRoleDevelopInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x00176BC1 File Offset: 0x00174DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx Clone()
		{
			return new GachaRoleDevelopInsCtx(this);
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06009B58 RID: 39768 RVA: 0x00176BC9 File Offset: 0x00174DC9
		// (set) Token: 0x06009B59 RID: 39769 RVA: 0x00176BD1 File Offset: 0x00174DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaRoleDevelopInsId
		{
			get
			{
				return this.gachaRoleDevelopInsId_;
			}
			set
			{
				this.gachaRoleDevelopInsId_ = value;
			}
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x00176BDA File Offset: 0x00174DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRoleDevelopInsCtx);
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x00176BE8 File Offset: 0x00174DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRoleDevelopInsCtx other)
		{
			return other != null && (other == this || (this.GachaRoleDevelopInsId == other.GachaRoleDevelopInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x00176C18 File Offset: 0x00174E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaRoleDevelopInsId != 0)
			{
				num ^= this.GachaRoleDevelopInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00176C57 File Offset: 0x00174E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00176C64 File Offset: 0x00174E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00176C6D File Offset: 0x00174E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRoleDevelopInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaRoleDevelopInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x00176CA0 File Offset: 0x00174EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaRoleDevelopInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaRoleDevelopInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x00176CDE File Offset: 0x00174EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRoleDevelopInsCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaRoleDevelopInsId != 0)
			{
				this.GachaRoleDevelopInsId = other.GachaRoleDevelopInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B62 RID: 39778 RVA: 0x00176D0F File Offset: 0x00174F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x00176D18 File Offset: 0x00174F18
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GachaRoleDevelopInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400495D RID: 18781
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400495E RID: 18782
		public const int GachaRoleDevelopInsIdFieldNumber = 1;

		// Token: 0x0400495F RID: 18783
		private int gachaRoleDevelopInsId_;
	}
}
