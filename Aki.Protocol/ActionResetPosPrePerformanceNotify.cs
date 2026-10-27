using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000079 RID: 121
	[NetMessage(EMessageId.ActionResetPosPrePerformanceNotify)]
	public sealed class ActionResetPosPrePerformanceNotify : IMessage<ActionResetPosPrePerformanceNotify>, IMessage, IEquatable<ActionResetPosPrePerformanceNotify>, IDeepCloneable<ActionResetPosPrePerformanceNotify>, IBufferMessage
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x0003F5E1 File Offset: 0x0003D7E1
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceNotify Create()
		{
			return new ActionResetPosPrePerformanceNotify();
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0003F5EB File Offset: 0x0003D7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceNotify.Descriptor;
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0003F5F2 File Offset: 0x0003D7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceNotify()
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0003F608 File Offset: 0x0003D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceNotify(ActionResetPosPrePerformanceNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.index_ = other.index_;
			this.params_ = other.params_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0003F678 File Offset: 0x0003D878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceNotify Clone()
		{
			return new ActionResetPosPrePerformanceNotify(this);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0003F680 File Offset: 0x0003D880
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x0003F688 File Offset: 0x0003D888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0003F691 File Offset: 0x0003D891
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0003F699 File Offset: 0x0003D899
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0003F6A2 File Offset: 0x0003D8A2
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0003F6AA File Offset: 0x0003D8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0003F6B3 File Offset: 0x0003D8B3
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0003F6BB File Offset: 0x0003D8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0003F6CE File Offset: 0x0003D8CE
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0003F6D6 File Offset: 0x0003D8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0003F6DF File Offset: 0x0003D8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceNotify);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && !(this.Params != other.Params) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0003F774 File Offset: 0x0003D974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Params.Length != 0)
			{
				num ^= this.Params.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0003F816 File Offset: 0x0003DA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0003F823 File Offset: 0x0003DA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0003F82C File Offset: 0x0003DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Params);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GameCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0003F8E0 File Offset: 0x0003DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Params.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Params);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0003F984 File Offset: 0x0003DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionResetPosPrePerformanceNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Params.Length != 0)
			{
				this.Params = other.Params;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0003FA2D File Offset: 0x0003DC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0003FA38 File Offset: 0x0003DC38
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.Params = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400216A RID: 8554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400216B RID: 8555
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400216C RID: 8556
		private int playerId_;

		// Token: 0x0400216D RID: 8557
		public const int IncIdFieldNumber = 12;

		// Token: 0x0400216E RID: 8558
		private int incId_;

		// Token: 0x0400216F RID: 8559
		public const int IndexFieldNumber = 6;

		// Token: 0x04002170 RID: 8560
		private int index_;

		// Token: 0x04002171 RID: 8561
		public const int ParamsFieldNumber = 11;

		// Token: 0x04002172 RID: 8562
		private string params_ = "";

		// Token: 0x04002173 RID: 8563
		public const int GameCtxFieldNumber = 15;

		// Token: 0x04002174 RID: 8564
		private GameCtxPb gameCtx_;
	}
}
