using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001158 RID: 4440
	[NetMessage(EMessageId.SceneGroupDataAndCurFormationEntityResponse)]
	public sealed class SceneGroupDataAndCurFormationEntityResponse : IMessage<SceneGroupDataAndCurFormationEntityResponse>, IMessage, IEquatable<SceneGroupDataAndCurFormationEntityResponse>, IDeepCloneable<SceneGroupDataAndCurFormationEntityResponse>, IBufferMessage
	{
		// Token: 0x06017AA5 RID: 96933 RVA: 0x0036F482 File Offset: 0x0036D682
		[NullableContext(1)]
		public static SceneGroupDataAndCurFormationEntityResponse Create()
		{
			return new SceneGroupDataAndCurFormationEntityResponse();
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06017AA6 RID: 96934 RVA: 0x0036F489 File Offset: 0x0036D689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06017AA7 RID: 96935 RVA: 0x0036F48C File Offset: 0x0036D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupDataAndCurFormationEntityResponse.Descriptor;
			}
		}

		// Token: 0x06017AA8 RID: 96936 RVA: 0x0036F493 File Offset: 0x0036D693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse()
		{
		}

		// Token: 0x06017AA9 RID: 96937 RVA: 0x0036F4B4 File Offset: 0x0036D6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse(SceneGroupDataAndCurFormationEntityResponse other) : this()
		{
			this.playerSceneGroupDataList_ = other.playerSceneGroupDataList_.Clone();
			this.curFormationRoleEntitys_ = other.curFormationRoleEntitys_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AAA RID: 96938 RVA: 0x0036F506 File Offset: 0x0036D706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityResponse Clone()
		{
			return new SceneGroupDataAndCurFormationEntityResponse(this);
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06017AAB RID: 96939 RVA: 0x0036F50E File Offset: 0x0036D70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupDataList> PlayerSceneGroupDataList
		{
			get
			{
				return this.playerSceneGroupDataList_;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x06017AAC RID: 96940 RVA: 0x0036F516 File Offset: 0x0036D716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> CurFormationRoleEntitys
		{
			get
			{
				return this.curFormationRoleEntitys_;
			}
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x06017AAD RID: 96941 RVA: 0x0036F51E File Offset: 0x0036D71E
		// (set) Token: 0x06017AAE RID: 96942 RVA: 0x0036F526 File Offset: 0x0036D726
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

		// Token: 0x06017AAF RID: 96943 RVA: 0x0036F52F File Offset: 0x0036D72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupDataAndCurFormationEntityResponse);
		}

		// Token: 0x06017AB0 RID: 96944 RVA: 0x0036F540 File Offset: 0x0036D740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupDataAndCurFormationEntityResponse other)
		{
			return other != null && (other == this || (this.playerSceneGroupDataList_.Equals(other.playerSceneGroupDataList_) && this.curFormationRoleEntitys_.Equals(other.curFormationRoleEntitys_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AB1 RID: 96945 RVA: 0x0036F5A4 File Offset: 0x0036D7A4
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

		// Token: 0x06017AB2 RID: 96946 RVA: 0x0036F605 File Offset: 0x0036D805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AB3 RID: 96947 RVA: 0x0036F612 File Offset: 0x0036D812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AB4 RID: 96948 RVA: 0x0036F61C File Offset: 0x0036D81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.playerSceneGroupDataList_.WriteTo(ref output, SceneGroupDataAndCurFormationEntityResponse._repeated_playerSceneGroupDataList_codec);
			this.curFormationRoleEntitys_.WriteTo(ref output, SceneGroupDataAndCurFormationEntityResponse._repeated_curFormationRoleEntitys_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017AB5 RID: 96949 RVA: 0x0036F67C File Offset: 0x0036D87C
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

		// Token: 0x06017AB6 RID: 96950 RVA: 0x0036F6E0 File Offset: 0x0036D8E0
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

		// Token: 0x06017AB7 RID: 96951 RVA: 0x0036F73E File Offset: 0x0036D93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017AB8 RID: 96952 RVA: 0x0036F748 File Offset: 0x0036D948
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
				if (num != 64U)
				{
					if (num != 82U)
					{
						if (num != 106U)
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

		// Token: 0x04008C68 RID: 35944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C69 RID: 35945
		public const int PlayerSceneGroupDataListFieldNumber = 10;

		// Token: 0x04008C6A RID: 35946
		private static readonly FieldCodec<PlayerSceneGroupDataList> _repeated_playerSceneGroupDataList_codec = FieldCodec.ForMessage<PlayerSceneGroupDataList>(82U, Aki.Protocol.PlayerSceneGroupDataList.Parser);

		// Token: 0x04008C6B RID: 35947
		private readonly RepeatedField<PlayerSceneGroupDataList> playerSceneGroupDataList_ = new RepeatedField<PlayerSceneGroupDataList>();

		// Token: 0x04008C6C RID: 35948
		public const int CurFormationRoleEntitysFieldNumber = 13;

		// Token: 0x04008C6D RID: 35949
		private static readonly FieldCodec<EntityPb> _repeated_curFormationRoleEntitys_codec = FieldCodec.ForMessage<EntityPb>(106U, EntityPb.Parser);

		// Token: 0x04008C6E RID: 35950
		private readonly RepeatedField<EntityPb> curFormationRoleEntitys_ = new RepeatedField<EntityPb>();

		// Token: 0x04008C6F RID: 35951
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008C70 RID: 35952
		private ErrorCode errorCode_;
	}
}
