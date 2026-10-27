using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001336 RID: 4918
	[NetMessage(EMessageId.TeleportDungeonActionRequest)]
	public sealed class TeleportDungeonActionRequest : IMessage<TeleportDungeonActionRequest>, IMessage, IEquatable<TeleportDungeonActionRequest>, IDeepCloneable<TeleportDungeonActionRequest>, IBufferMessage
	{
		// Token: 0x0601A20F RID: 107023 RVA: 0x003CB8A9 File Offset: 0x003C9AA9
		[NullableContext(1)]
		public static TeleportDungeonActionRequest Create()
		{
			return new TeleportDungeonActionRequest();
		}

		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x0601A210 RID: 107024 RVA: 0x003CB8B0 File Offset: 0x003C9AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x0601A211 RID: 107025 RVA: 0x003CB8B3 File Offset: 0x003C9AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionRequest.Descriptor;
			}
		}

		// Token: 0x0601A212 RID: 107026 RVA: 0x003CB8BA File Offset: 0x003C9ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest()
		{
		}

		// Token: 0x0601A213 RID: 107027 RVA: 0x003CB8D0 File Offset: 0x003C9AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest(TeleportDungeonActionRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.incId_ = other.incId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.isConfirm_ = other.isConfirm_;
			this.continueLastInst_ = other.continueLastInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A214 RID: 107028 RVA: 0x003CB935 File Offset: 0x003C9B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest Clone()
		{
			return new TeleportDungeonActionRequest(this);
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x0601A215 RID: 107029 RVA: 0x003CB93D File Offset: 0x003C9B3D
		// (set) Token: 0x0601A216 RID: 107030 RVA: 0x003CB945 File Offset: 0x003C9B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x0601A217 RID: 107031 RVA: 0x003CB94E File Offset: 0x003C9B4E
		// (set) Token: 0x0601A218 RID: 107032 RVA: 0x003CB956 File Offset: 0x003C9B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x0601A219 RID: 107033 RVA: 0x003CB95F File Offset: 0x003C9B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x0601A21A RID: 107034 RVA: 0x003CB967 File Offset: 0x003C9B67
		// (set) Token: 0x0601A21B RID: 107035 RVA: 0x003CB96F File Offset: 0x003C9B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConfirm
		{
			get
			{
				return this.isConfirm_;
			}
			set
			{
				this.isConfirm_ = value;
			}
		}

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x0601A21C RID: 107036 RVA: 0x003CB978 File Offset: 0x003C9B78
		// (set) Token: 0x0601A21D RID: 107037 RVA: 0x003CB980 File Offset: 0x003C9B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastInst
		{
			get
			{
				return this.continueLastInst_;
			}
			set
			{
				this.continueLastInst_ = value;
			}
		}

		// Token: 0x0601A21E RID: 107038 RVA: 0x003CB989 File Offset: 0x003C9B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionRequest);
		}

		// Token: 0x0601A21F RID: 107039 RVA: 0x003CB998 File Offset: 0x003C9B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.IncId == other.IncId && this.roleIds_.Equals(other.roleIds_) && this.IsConfirm == other.IsConfirm && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A220 RID: 107040 RVA: 0x003CBA18 File Offset: 0x003C9C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.IsConfirm)
			{
				num ^= this.IsConfirm.GetHashCode();
			}
			if (this.ContinueLastInst)
			{
				num ^= this.ContinueLastInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A221 RID: 107041 RVA: 0x003CBAB0 File Offset: 0x003C9CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A222 RID: 107042 RVA: 0x003CBABD File Offset: 0x003C9CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A223 RID: 107043 RVA: 0x003CBAC8 File Offset: 0x003C9CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			if (this.IsConfirm)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsConfirm);
			}
			this.roleIds_.WriteTo(ref output, TeleportDungeonActionRequest._repeated_roleIds_codec);
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ContinueLastInst);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A224 RID: 107044 RVA: 0x003CBB6C File Offset: 0x003C9D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.roleIds_.CalculateSize(TeleportDungeonActionRequest._repeated_roleIds_codec);
			if (this.IsConfirm)
			{
				num += 2;
			}
			if (this.ContinueLastInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A225 RID: 107045 RVA: 0x003CBBF0 File Offset: 0x003C9DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.IsConfirm)
			{
				this.IsConfirm = other.IsConfirm;
			}
			if (other.ContinueLastInst)
			{
				this.ContinueLastInst = other.ContinueLastInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A226 RID: 107046 RVA: 0x003CBC79 File Offset: 0x003C9E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A227 RID: 107047 RVA: 0x003CBC84 File Offset: 0x003C9E84
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
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.IsConfirm = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_61;
					}
					if (num == 96U)
					{
						this.ContinueLastInst = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.roleIds_.AddEntriesFrom(ref input, TeleportDungeonActionRequest._repeated_roleIds_codec);
			}
		}

		// Token: 0x0400987E RID: 39038
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400987F RID: 39039
		public const int HostPlayerIdFieldNumber = 15;

		// Token: 0x04009880 RID: 39040
		private int hostPlayerId_;

		// Token: 0x04009881 RID: 39041
		public const int IncIdFieldNumber = 6;

		// Token: 0x04009882 RID: 39042
		private int incId_;

		// Token: 0x04009883 RID: 39043
		public const int RoleIdsFieldNumber = 8;

		// Token: 0x04009884 RID: 39044
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009885 RID: 39045
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04009886 RID: 39046
		public const int IsConfirmFieldNumber = 7;

		// Token: 0x04009887 RID: 39047
		private bool isConfirm_;

		// Token: 0x04009888 RID: 39048
		public const int ContinueLastInstFieldNumber = 12;

		// Token: 0x04009889 RID: 39049
		private bool continueLastInst_;
	}
}
