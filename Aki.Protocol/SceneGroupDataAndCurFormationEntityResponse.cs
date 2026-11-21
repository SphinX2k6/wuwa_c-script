using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001192 RID: 4498
	[NetMessage(EMessageId.SceneGroupDataAndCurFormationEntityResponse)]
	public sealed class SceneGroupDataAndCurFormationEntityResponse : IMessage<SceneGroupDataAndCurFormationEntityResponse>, IMessage, IEquatable<SceneGroupDataAndCurFormationEntityResponse>, IDeepCloneable<SceneGroupDataAndCurFormationEntityResponse>, IBufferMessage
	{
		// Token: 0x06018046 RID: 98374 RVA: 0x0037E7D2 File Offset: 0x0037C9D2
		[NullableContext(1)]
		public static SceneGroupDataAndCurFormationEntityResponse Create()
		{
			return new SceneGroupDataAndCurFormationEntityResponse();
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x06018047 RID: 98375 RVA: 0x0037E7D9 File Offset: 0x0037C9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x06018048 RID: 98376 RVA: 0x0037E7DC File Offset: 0x0037C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupDataAndCurFormationEntityResponse.Descriptor;
			}
		}

		// Token: 0x06018049 RID: 98377 RVA: 0x0037E7E3 File Offset: 0x0037C9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse()
		{
		}

		// Token: 0x0601804A RID: 98378 RVA: 0x0037E804 File Offset: 0x0037CA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse(SceneGroupDataAndCurFormationEntityResponse other) : this()
		{
			this.playerSceneGroupDataList_ = other.playerSceneGroupDataList_.Clone();
			this.curFormationRoleEntitys_ = other.curFormationRoleEntitys_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601804B RID: 98379 RVA: 0x0037E856 File Offset: 0x0037CA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse Clone()
		{
			return new SceneGroupDataAndCurFormationEntityResponse(this);
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x0601804C RID: 98380 RVA: 0x0037E85E File Offset: 0x0037CA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupDataList> PlayerSceneGroupDataList
		{
			get
			{
				return this.playerSceneGroupDataList_;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x0601804D RID: 98381 RVA: 0x0037E866 File Offset: 0x0037CA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> CurFormationRoleEntitys
		{
			get
			{
				return this.curFormationRoleEntitys_;
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x0601804E RID: 98382 RVA: 0x0037E86E File Offset: 0x0037CA6E
		// (set) Token: 0x0601804F RID: 98383 RVA: 0x0037E876 File Offset: 0x0037CA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x0037E87F File Offset: 0x0037CA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupDataAndCurFormationEntityResponse);
		}

		// Token: 0x06018051 RID: 98385 RVA: 0x0037E890 File Offset: 0x0037CA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupDataAndCurFormationEntityResponse other)
		{
			return other != null && (other == this || (this.playerSceneGroupDataList_.Equals(other.playerSceneGroupDataList_) && this.curFormationRoleEntitys_.Equals(other.curFormationRoleEntitys_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018052 RID: 98386 RVA: 0x0037E8F4 File Offset: 0x0037CAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerSceneGroupDataList_.GetHashCode();
			num ^= this.curFormationRoleEntitys_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018053 RID: 98387 RVA: 0x0037E955 File Offset: 0x0037CB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018054 RID: 98388 RVA: 0x0037E962 File Offset: 0x0037CB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018055 RID: 98389 RVA: 0x0037E96C File Offset: 0x0037CB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.playerSceneGroupDataList_.WriteTo(ref output, SceneGroupDataAndCurFormationEntityResponse._repeated_playerSceneGroupDataList_codec);
			this.curFormationRoleEntitys_.WriteTo(ref output, SceneGroupDataAndCurFormationEntityResponse._repeated_curFormationRoleEntitys_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018056 RID: 98390 RVA: 0x0037E9CC File Offset: 0x0037CBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerSceneGroupDataList_.CalculateSize(SceneGroupDataAndCurFormationEntityResponse._repeated_playerSceneGroupDataList_codec);
			num += this.curFormationRoleEntitys_.CalculateSize(SceneGroupDataAndCurFormationEntityResponse._repeated_curFormationRoleEntitys_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018057 RID: 98391 RVA: 0x0037EA30 File Offset: 0x0037CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGroupDataAndCurFormationEntityResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.playerSceneGroupDataList_.Add(other.playerSceneGroupDataList_);
			this.curFormationRoleEntitys_.Add(other.curFormationRoleEntitys_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018058 RID: 98392 RVA: 0x0037EA8E File Offset: 0x0037CC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018059 RID: 98393 RVA: 0x0037EA98 File Offset: 0x0037CC98
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
					if (num != 18U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.curFormationRoleEntitys_.AddEntriesFrom(ref input, SceneGroupDataAndCurFormationEntityResponse._repeated_curFormationRoleEntitys_codec);
						}
					}
					else
					{
						this.playerSceneGroupDataList_.AddEntriesFrom(ref input, SceneGroupDataAndCurFormationEntityResponse._repeated_playerSceneGroupDataList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008EFB RID: 36603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EFC RID: 36604
		public const int PlayerSceneGroupDataListFieldNumber = 2;

		// Token: 0x04008EFD RID: 36605
		private static readonly FieldCodec<PlayerSceneGroupDataList> _repeated_playerSceneGroupDataList_codec = FieldCodec.ForMessage<PlayerSceneGroupDataList>(18U, Aki.Protocol.PlayerSceneGroupDataList.Parser);

		// Token: 0x04008EFE RID: 36606
		private readonly RepeatedField<PlayerSceneGroupDataList> playerSceneGroupDataList_ = new RepeatedField<PlayerSceneGroupDataList>();

		// Token: 0x04008EFF RID: 36607
		public const int CurFormationRoleEntitysFieldNumber = 11;

		// Token: 0x04008F00 RID: 36608
		private static readonly FieldCodec<EntityPb> _repeated_curFormationRoleEntitys_codec = FieldCodec.ForMessage<EntityPb>(90U, EntityPb.Parser);

		// Token: 0x04008F01 RID: 36609
		private readonly RepeatedField<EntityPb> curFormationRoleEntitys_ = new RepeatedField<EntityPb>();

		// Token: 0x04008F02 RID: 36610
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008F03 RID: 36611
		private ErrorCode errorCode_;
	}
}
