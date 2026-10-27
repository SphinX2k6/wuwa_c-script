using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACD RID: 2765
	[NetMessage(EMessageId.MowTowerLevelsInfoUpdateNotify)]
	public sealed class MowTowerLevelsInfoUpdateNotify : IMessage<MowTowerLevelsInfoUpdateNotify>, IMessage, IEquatable<MowTowerLevelsInfoUpdateNotify>, IDeepCloneable<MowTowerLevelsInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F0C3 RID: 61635 RVA: 0x00232F96 File Offset: 0x00231196
		[NullableContext(1)]
		public static MowTowerLevelsInfoUpdateNotify Create()
		{
			return new MowTowerLevelsInfoUpdateNotify();
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600F0C4 RID: 61636 RVA: 0x00232F9D File Offset: 0x0023119D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600F0C5 RID: 61637 RVA: 0x00232FA0 File Offset: 0x002311A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F0C6 RID: 61638 RVA: 0x00232FA7 File Offset: 0x002311A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify()
		{
		}

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x00232FBA File Offset: 0x002311BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify(MowTowerLevelsInfoUpdateNotify other) : this()
		{
			this.mowTowerLevelsInfos_ = other.mowTowerLevelsInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0C8 RID: 61640 RVA: 0x00232FE4 File Offset: 0x002311E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify Clone()
		{
			return new MowTowerLevelsInfoUpdateNotify(this);
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600F0C9 RID: 61641 RVA: 0x00232FEC File Offset: 0x002311EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MowTowerLevelsInfo> MowTowerLevelsInfos
		{
			get
			{
				return this.mowTowerLevelsInfos_;
			}
		}

		// Token: 0x0600F0CA RID: 61642 RVA: 0x00232FF4 File Offset: 0x002311F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsInfoUpdateNotify);
		}

		// Token: 0x0600F0CB RID: 61643 RVA: 0x00233002 File Offset: 0x00231202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.mowTowerLevelsInfos_.Equals(other.mowTowerLevelsInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0CC RID: 61644 RVA: 0x00233038 File Offset: 0x00231238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mowTowerLevelsInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0CD RID: 61645 RVA: 0x0023306C File Offset: 0x0023126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0CE RID: 61646 RVA: 0x00233079 File Offset: 0x00231279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0CF RID: 61647 RVA: 0x00233082 File Offset: 0x00231282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mowTowerLevelsInfos_.WriteTo(ref output, MowTowerLevelsInfoUpdateNotify._repeated_mowTowerLevelsInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F0D0 RID: 61648 RVA: 0x002330AC File Offset: 0x002312AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mowTowerLevelsInfos_.CalculateSize(MowTowerLevelsInfoUpdateNotify._repeated_mowTowerLevelsInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0D1 RID: 61649 RVA: 0x002330E5 File Offset: 0x002312E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mowTowerLevelsInfos_.Add(other.mowTowerLevelsInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0D2 RID: 61650 RVA: 0x00233113 File Offset: 0x00231313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0D3 RID: 61651 RVA: 0x0023311C File Offset: 0x0023131C
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mowTowerLevelsInfos_.AddEntriesFrom(ref input, MowTowerLevelsInfoUpdateNotify._repeated_mowTowerLevelsInfos_codec);
				}
			}
		}

		// Token: 0x0400615B RID: 24923
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400615C RID: 24924
		public const int MowTowerLevelsInfosFieldNumber = 8;

		// Token: 0x0400615D RID: 24925
		private static readonly FieldCodec<MowTowerLevelsInfo> _repeated_mowTowerLevelsInfos_codec = FieldCodec.ForMessage<MowTowerLevelsInfo>(66U, MowTowerLevelsInfo.Parser);

		// Token: 0x0400615E RID: 24926
		private readonly RepeatedField<MowTowerLevelsInfo> mowTowerLevelsInfos_ = new RepeatedField<MowTowerLevelsInfo>();
	}
}
