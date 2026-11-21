using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068D RID: 1677
	public sealed class GachaRoleDevelopInsCtx : IMessage<GachaRoleDevelopInsCtx>, IMessage, IEquatable<GachaRoleDevelopInsCtx>, IDeepCloneable<GachaRoleDevelopInsCtx>, IBufferMessage
	{
		// Token: 0x060099FC RID: 39420 RVA: 0x0017414F File Offset: 0x0017234F
		[NullableContext(1)]
		public static GachaRoleDevelopInsCtx Create()
		{
			return new GachaRoleDevelopInsCtx();
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x00174156 File Offset: 0x00172356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x060099FE RID: 39422 RVA: 0x00174159 File Offset: 0x00172359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRoleDevelopInsCtx.Descriptor;
			}
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x00174160 File Offset: 0x00172360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx()
		{
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x00174168 File Offset: 0x00172368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx(GachaRoleDevelopInsCtx other) : this()
		{
			this.gachaRoleDevelopInsId_ = other.gachaRoleDevelopInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A01 RID: 39425 RVA: 0x0017418D File Offset: 0x0017238D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRoleDevelopInsCtx Clone()
		{
			return new GachaRoleDevelopInsCtx(this);
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06009A02 RID: 39426 RVA: 0x00174195 File Offset: 0x00172395
		// (set) Token: 0x06009A03 RID: 39427 RVA: 0x0017419D File Offset: 0x0017239D
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

		// Token: 0x06009A04 RID: 39428 RVA: 0x001741A6 File Offset: 0x001723A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRoleDevelopInsCtx);
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x001741B4 File Offset: 0x001723B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRoleDevelopInsCtx other)
		{
			return other != null && (other == this || (this.GachaRoleDevelopInsId == other.GachaRoleDevelopInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x001741E4 File Offset: 0x001723E4
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

		// Token: 0x06009A07 RID: 39431 RVA: 0x00174223 File Offset: 0x00172423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x00174230 File Offset: 0x00172430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x00174239 File Offset: 0x00172439
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

		// Token: 0x06009A0A RID: 39434 RVA: 0x0017426C File Offset: 0x0017246C
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

		// Token: 0x06009A0B RID: 39435 RVA: 0x001742AA File Offset: 0x001724AA
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

		// Token: 0x06009A0C RID: 39436 RVA: 0x001742DB File Offset: 0x001724DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x001742E4 File Offset: 0x001724E4
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

		// Token: 0x04004956 RID: 18774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004957 RID: 18775
		public const int GachaRoleDevelopInsIdFieldNumber = 1;

		// Token: 0x04004958 RID: 18776
		private int gachaRoleDevelopInsId_;
	}
}
