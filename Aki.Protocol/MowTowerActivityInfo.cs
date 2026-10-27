using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC9 RID: 2761
	public sealed class MowTowerActivityInfo : IMessage<MowTowerActivityInfo>, IMessage, IEquatable<MowTowerActivityInfo>, IDeepCloneable<MowTowerActivityInfo>, IBufferMessage
	{
		// Token: 0x0600F066 RID: 61542 RVA: 0x00231F56 File Offset: 0x00230156
		[NullableContext(1)]
		public static MowTowerActivityInfo Create()
		{
			return new MowTowerActivityInfo();
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600F067 RID: 61543 RVA: 0x00231F5D File Offset: 0x0023015D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600F068 RID: 61544 RVA: 0x00231F60 File Offset: 0x00230160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600F069 RID: 61545 RVA: 0x00231F67 File Offset: 0x00230167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo()
		{
		}

		// Token: 0x0600F06A RID: 61546 RVA: 0x00231F7A File Offset: 0x0023017A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo(MowTowerActivityInfo other) : this()
		{
			this.mowTowerLevelInfos_ = other.mowTowerLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F06B RID: 61547 RVA: 0x00231FA4 File Offset: 0x002301A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo Clone()
		{
			return new MowTowerActivityInfo(this);
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x00231FAC File Offset: 0x002301AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MowTowerLevelsInfo> MowTowerLevelInfos
		{
			get
			{
				return this.mowTowerLevelInfos_;
			}
		}

		// Token: 0x0600F06D RID: 61549 RVA: 0x00231FB4 File Offset: 0x002301B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerActivityInfo);
		}

		// Token: 0x0600F06E RID: 61550 RVA: 0x00231FC2 File Offset: 0x002301C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerActivityInfo other)
		{
			return other != null && (other == this || (this.mowTowerLevelInfos_.Equals(other.mowTowerLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F06F RID: 61551 RVA: 0x00231FF8 File Offset: 0x002301F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mowTowerLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F070 RID: 61552 RVA: 0x0023202C File Offset: 0x0023022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F071 RID: 61553 RVA: 0x00232039 File Offset: 0x00230239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F072 RID: 61554 RVA: 0x00232042 File Offset: 0x00230242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mowTowerLevelInfos_.WriteTo(ref output, MowTowerActivityInfo._repeated_mowTowerLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F073 RID: 61555 RVA: 0x0023206C File Offset: 0x0023026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mowTowerLevelInfos_.CalculateSize(MowTowerActivityInfo._repeated_mowTowerLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F074 RID: 61556 RVA: 0x002320A5 File Offset: 0x002302A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.mowTowerLevelInfos_.Add(other.mowTowerLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F075 RID: 61557 RVA: 0x002320D3 File Offset: 0x002302D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F076 RID: 61558 RVA: 0x002320DC File Offset: 0x002302DC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mowTowerLevelInfos_.AddEntriesFrom(ref input, MowTowerActivityInfo._repeated_mowTowerLevelInfos_codec);
				}
			}
		}

		// Token: 0x0400612F RID: 24879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006130 RID: 24880
		public const int MowTowerLevelInfosFieldNumber = 1;

		// Token: 0x04006131 RID: 24881
		private static readonly FieldCodec<MowTowerLevelsInfo> _repeated_mowTowerLevelInfos_codec = FieldCodec.ForMessage<MowTowerLevelsInfo>(10U, MowTowerLevelsInfo.Parser);

		// Token: 0x04006132 RID: 24882
		private readonly RepeatedField<MowTowerLevelsInfo> mowTowerLevelInfos_ = new RepeatedField<MowTowerLevelsInfo>();
	}
}
