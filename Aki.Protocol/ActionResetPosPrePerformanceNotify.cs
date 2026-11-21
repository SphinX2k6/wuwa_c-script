using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007A RID: 122
	[NetMessage(EMessageId.ActionResetPosPrePerformanceNotify)]
	public sealed class ActionResetPosPrePerformanceNotify : IMessage<ActionResetPosPrePerformanceNotify>, IMessage, IEquatable<ActionResetPosPrePerformanceNotify>, IDeepCloneable<ActionResetPosPrePerformanceNotify>, IBufferMessage
	{
		// Token: 0x0600186E RID: 6254 RVA: 0x0003FF85 File Offset: 0x0003E185
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceNotify Create()
		{
			return new ActionResetPosPrePerformanceNotify();
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0003FF8C File Offset: 0x0003E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0003FF8F File Offset: 0x0003E18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceNotify.Descriptor;
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0003FF96 File Offset: 0x0003E196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceNotify()
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0003FFAC File Offset: 0x0003E1AC
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

		// Token: 0x06001873 RID: 6259 RVA: 0x0004001C File Offset: 0x0003E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceNotify Clone()
		{
			return new ActionResetPosPrePerformanceNotify(this);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00040024 File Offset: 0x0003E224
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0004002C File Offset: 0x0003E22C
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00040035 File Offset: 0x0003E235
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0004003D File Offset: 0x0003E23D
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00040046 File Offset: 0x0003E246
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0004004E File Offset: 0x0003E24E
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00040057 File Offset: 0x0003E257
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0004005F File Offset: 0x0003E25F
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00040072 File Offset: 0x0003E272
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0004007A File Offset: 0x0003E27A
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

		// Token: 0x0600187E RID: 6270 RVA: 0x00040083 File Offset: 0x0003E283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceNotify);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00040094 File Offset: 0x0003E294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && !(this.Params != other.Params) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00040118 File Offset: 0x0003E318
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

		// Token: 0x06001881 RID: 6273 RVA: 0x000401BA File Offset: 0x0003E3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000401C7 File Offset: 0x0003E3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000401D0 File Offset: 0x0003E3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Params);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GameCtx);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00040284 File Offset: 0x0003E484
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

		// Token: 0x06001885 RID: 6277 RVA: 0x00040328 File Offset: 0x0003E528
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

		// Token: 0x06001886 RID: 6278 RVA: 0x000403D1 File Offset: 0x0003E5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000403DC File Offset: 0x0003E5DC
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
				if (num <= 42U)
				{
					if (num == 18U)
					{
						this.Params = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021C9 RID: 8649
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021CA RID: 8650
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x040021CB RID: 8651
		private int playerId_;

		// Token: 0x040021CC RID: 8652
		public const int IncIdFieldNumber = 7;

		// Token: 0x040021CD RID: 8653
		private int incId_;

		// Token: 0x040021CE RID: 8654
		public const int IndexFieldNumber = 9;

		// Token: 0x040021CF RID: 8655
		private int index_;

		// Token: 0x040021D0 RID: 8656
		public const int ParamsFieldNumber = 2;

		// Token: 0x040021D1 RID: 8657
		private string params_ = "";

		// Token: 0x040021D2 RID: 8658
		public const int GameCtxFieldNumber = 5;

		// Token: 0x040021D3 RID: 8659
		private GameCtxPb gameCtx_;
	}
}
