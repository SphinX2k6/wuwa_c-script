using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB8 RID: 2744
	public sealed class MowTowerActivityInfo : IMessage<MowTowerActivityInfo>, IMessage, IEquatable<MowTowerActivityInfo>, IDeepCloneable<MowTowerActivityInfo>, IBufferMessage
	{
		// Token: 0x0600EF4C RID: 61260 RVA: 0x0022FD4A File Offset: 0x0022DF4A
		[NullableContext(1)]
		public static MowTowerActivityInfo Create()
		{
			return new MowTowerActivityInfo();
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600EF4D RID: 61261 RVA: 0x0022FD51 File Offset: 0x0022DF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600EF4E RID: 61262 RVA: 0x0022FD54 File Offset: 0x0022DF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600EF4F RID: 61263 RVA: 0x0022FD5B File Offset: 0x0022DF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo()
		{
		}

		// Token: 0x0600EF50 RID: 61264 RVA: 0x0022FD6E File Offset: 0x0022DF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo(MowTowerActivityInfo other) : this()
		{
			this.mowTowerLevelInfos_ = other.mowTowerLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF51 RID: 61265 RVA: 0x0022FD98 File Offset: 0x0022DF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerActivityInfo Clone()
		{
			return new MowTowerActivityInfo(this);
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600EF52 RID: 61266 RVA: 0x0022FDA0 File Offset: 0x0022DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MowTowerLevelsInfo> MowTowerLevelInfos
		{
			get
			{
				return this.mowTowerLevelInfos_;
			}
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x0022FDA8 File Offset: 0x0022DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerActivityInfo);
		}

		// Token: 0x0600EF54 RID: 61268 RVA: 0x0022FDB6 File Offset: 0x0022DFB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerActivityInfo other)
		{
			return other != null && (other == this || (this.mowTowerLevelInfos_.Equals(other.mowTowerLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF55 RID: 61269 RVA: 0x0022FDEC File Offset: 0x0022DFEC
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

		// Token: 0x0600EF56 RID: 61270 RVA: 0x0022FE20 File Offset: 0x0022E020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x0022FE2D File Offset: 0x0022E02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x0022FE36 File Offset: 0x0022E036
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

		// Token: 0x0600EF59 RID: 61273 RVA: 0x0022FE60 File Offset: 0x0022E060
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

		// Token: 0x0600EF5A RID: 61274 RVA: 0x0022FE99 File Offset: 0x0022E099
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

		// Token: 0x0600EF5B RID: 61275 RVA: 0x0022FEC7 File Offset: 0x0022E0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF5C RID: 61276 RVA: 0x0022FED0 File Offset: 0x0022E0D0
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

		// Token: 0x04006138 RID: 24888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006139 RID: 24889
		public const int MowTowerLevelInfosFieldNumber = 1;

		// Token: 0x0400613A RID: 24890
		private static readonly FieldCodec<MowTowerLevelsInfo> _repeated_mowTowerLevelInfos_codec = FieldCodec.ForMessage<MowTowerLevelsInfo>(10U, MowTowerLevelsInfo.Parser);

		// Token: 0x0400613B RID: 24891
		private readonly RepeatedField<MowTowerLevelsInfo> mowTowerLevelInfos_ = new RepeatedField<MowTowerLevelsInfo>();
	}
}
