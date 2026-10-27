using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C8 RID: 4296
	[NetMessage(EMessageId.RoleTrialCloseNotify)]
	public sealed class RoleTrialCloseNotify : IMessage<RoleTrialCloseNotify>, IMessage, IEquatable<RoleTrialCloseNotify>, IDeepCloneable<RoleTrialCloseNotify>, IBufferMessage
	{
		// Token: 0x06016EC7 RID: 93895 RVA: 0x00353F3C File Offset: 0x0035213C
		[NullableContext(1)]
		public static RoleTrialCloseNotify Create()
		{
			return new RoleTrialCloseNotify();
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x06016EC8 RID: 93896 RVA: 0x00353F43 File Offset: 0x00352143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x06016EC9 RID: 93897 RVA: 0x00353F46 File Offset: 0x00352146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialCloseNotify.Descriptor;
			}
		}

		// Token: 0x06016ECA RID: 93898 RVA: 0x00353F4D File Offset: 0x0035214D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify()
		{
		}

		// Token: 0x06016ECB RID: 93899 RVA: 0x00353F6C File Offset: 0x0035216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify(RoleTrialCloseNotify other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this.enableMapAndTeleport_ = other.enableMapAndTeleport_;
			this.canEnterDungeonList_ = other.canEnterDungeonList_.Clone();
			this.showTips_ = other.showTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x00353FCA File Offset: 0x003521CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify Clone()
		{
			return new RoleTrialCloseNotify(this);
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x06016ECD RID: 93901 RVA: 0x00353FD2 File Offset: 0x003521D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x06016ECE RID: 93902 RVA: 0x00353FDA File Offset: 0x003521DA
		// (set) Token: 0x06016ECF RID: 93903 RVA: 0x00353FE2 File Offset: 0x003521E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableMapAndTeleport
		{
			get
			{
				return this.enableMapAndTeleport_;
			}
			set
			{
				this.enableMapAndTeleport_ = value;
			}
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x06016ED0 RID: 93904 RVA: 0x00353FEB File Offset: 0x003521EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanEnterDungeonList
		{
			get
			{
				return this.canEnterDungeonList_;
			}
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x06016ED1 RID: 93905 RVA: 0x00353FF3 File Offset: 0x003521F3
		// (set) Token: 0x06016ED2 RID: 93906 RVA: 0x00353FFB File Offset: 0x003521FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowTips
		{
			get
			{
				return this.showTips_;
			}
			set
			{
				this.showTips_ = value;
			}
		}

		// Token: 0x06016ED3 RID: 93907 RVA: 0x00354004 File Offset: 0x00352204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialCloseNotify);
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x00354014 File Offset: 0x00352214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialCloseNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.EnableMapAndTeleport == other.EnableMapAndTeleport && this.canEnterDungeonList_.Equals(other.canEnterDungeonList_) && this.ShowTips == other.ShowTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016ED5 RID: 93909 RVA: 0x00354088 File Offset: 0x00352288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			if (this.EnableMapAndTeleport)
			{
				num ^= this.EnableMapAndTeleport.GetHashCode();
			}
			num ^= this.canEnterDungeonList_.GetHashCode();
			if (this.ShowTips)
			{
				num ^= this.ShowTips.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016ED6 RID: 93910 RVA: 0x003540FC File Offset: 0x003522FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016ED7 RID: 93911 RVA: 0x00354109 File Offset: 0x00352309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ED8 RID: 93912 RVA: 0x00354114 File Offset: 0x00352314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.canEnterDungeonList_.WriteTo(ref output, RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
			if (this.EnableMapAndTeleport)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.EnableMapAndTeleport);
			}
			if (this.ShowTips)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ShowTips);
			}
			this.roleIds_.WriteTo(ref output, RoleTrialCloseNotify._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016ED9 RID: 93913 RVA: 0x00354190 File Offset: 0x00352390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(RoleTrialCloseNotify._repeated_roleIds_codec);
			if (this.EnableMapAndTeleport)
			{
				num += 2;
			}
			num += this.canEnterDungeonList_.CalculateSize(RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
			if (this.ShowTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EDA RID: 93914 RVA: 0x003541F4 File Offset: 0x003523F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialCloseNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.EnableMapAndTeleport)
			{
				this.EnableMapAndTeleport = other.EnableMapAndTeleport;
			}
			this.canEnterDungeonList_.Add(other.canEnterDungeonList_);
			if (other.ShowTips)
			{
				this.ShowTips = other.ShowTips;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EDB RID: 93915 RVA: 0x00354266 File Offset: 0x00352466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EDC RID: 93916 RVA: 0x00354270 File Offset: 0x00352470
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
				if (num <= 32U)
				{
					if (num == 24U || num == 26U)
					{
						this.canEnterDungeonList_.AddEntriesFrom(ref input, RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
						continue;
					}
					if (num == 32U)
					{
						this.EnableMapAndTeleport = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ShowTips = input.ReadBool();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.roleIds_.AddEntriesFrom(ref input, RoleTrialCloseNotify._repeated_roleIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008895 RID: 34965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008896 RID: 34966
		public const int RoleIdsFieldNumber = 13;

		// Token: 0x04008897 RID: 34967
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008898 RID: 34968
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008899 RID: 34969
		public const int EnableMapAndTeleportFieldNumber = 4;

		// Token: 0x0400889A RID: 34970
		private bool enableMapAndTeleport_;

		// Token: 0x0400889B RID: 34971
		public const int CanEnterDungeonListFieldNumber = 3;

		// Token: 0x0400889C RID: 34972
		private static readonly FieldCodec<int> _repeated_canEnterDungeonList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400889D RID: 34973
		private readonly RepeatedField<int> canEnterDungeonList_ = new RepeatedField<int>();

		// Token: 0x0400889E RID: 34974
		public const int ShowTipsFieldNumber = 6;

		// Token: 0x0400889F RID: 34975
		private bool showTips_;
	}
}
