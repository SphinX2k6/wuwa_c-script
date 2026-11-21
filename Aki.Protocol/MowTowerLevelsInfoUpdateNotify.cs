using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABC RID: 2748
	[NetMessage(EMessageId.MowTowerLevelsInfoUpdateNotify)]
	public sealed class MowTowerLevelsInfoUpdateNotify : IMessage<MowTowerLevelsInfoUpdateNotify>, IMessage, IEquatable<MowTowerLevelsInfoUpdateNotify>, IDeepCloneable<MowTowerLevelsInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600EFA9 RID: 61353 RVA: 0x00230D86 File Offset: 0x0022EF86
		[NullableContext(1)]
		public static MowTowerLevelsInfoUpdateNotify Create()
		{
			return new MowTowerLevelsInfoUpdateNotify();
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600EFAA RID: 61354 RVA: 0x00230D8D File Offset: 0x0022EF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600EFAB RID: 61355 RVA: 0x00230D90 File Offset: 0x0022EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x00230D97 File Offset: 0x0022EF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify()
		{
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x00230DAA File Offset: 0x0022EFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify(MowTowerLevelsInfoUpdateNotify other) : this()
		{
			this.mowTowerLevelsInfos_ = other.mowTowerLevelsInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x00230DD4 File Offset: 0x0022EFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfoUpdateNotify Clone()
		{
			return new MowTowerLevelsInfoUpdateNotify(this);
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600EFAF RID: 61359 RVA: 0x00230DDC File Offset: 0x0022EFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MowTowerLevelsInfo> MowTowerLevelsInfos
		{
			get
			{
				return this.mowTowerLevelsInfos_;
			}
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x00230DE4 File Offset: 0x0022EFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsInfoUpdateNotify);
		}

		// Token: 0x0600EFB1 RID: 61361 RVA: 0x00230DF2 File Offset: 0x0022EFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.mowTowerLevelsInfos_.Equals(other.mowTowerLevelsInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFB2 RID: 61362 RVA: 0x00230E28 File Offset: 0x0022F028
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

		// Token: 0x0600EFB3 RID: 61363 RVA: 0x00230E5C File Offset: 0x0022F05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x00230E69 File Offset: 0x0022F069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFB5 RID: 61365 RVA: 0x00230E72 File Offset: 0x0022F072
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

		// Token: 0x0600EFB6 RID: 61366 RVA: 0x00230E9C File Offset: 0x0022F09C
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

		// Token: 0x0600EFB7 RID: 61367 RVA: 0x00230ED5 File Offset: 0x0022F0D5
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

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x00230F03 File Offset: 0x0022F103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFB9 RID: 61369 RVA: 0x00230F0C File Offset: 0x0022F10C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mowTowerLevelsInfos_.AddEntriesFrom(ref input, MowTowerLevelsInfoUpdateNotify._repeated_mowTowerLevelsInfos_codec);
				}
			}
		}

		// Token: 0x04006164 RID: 24932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006165 RID: 24933
		public const int MowTowerLevelsInfosFieldNumber = 13;

		// Token: 0x04006166 RID: 24934
		private static readonly FieldCodec<MowTowerLevelsInfo> _repeated_mowTowerLevelsInfos_codec = FieldCodec.ForMessage<MowTowerLevelsInfo>(106U, MowTowerLevelsInfo.Parser);

		// Token: 0x04006167 RID: 24935
		private readonly RepeatedField<MowTowerLevelsInfo> mowTowerLevelsInfos_ = new RepeatedField<MowTowerLevelsInfo>();
	}
}
