using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AF RID: 5295
	[NetMessage(EMessageId.TrapDefenseRefreshGainingGroupResponse)]
	public sealed class TrapDefenseRefreshGainingGroupResponse : IMessage<TrapDefenseRefreshGainingGroupResponse>, IMessage, IEquatable<TrapDefenseRefreshGainingGroupResponse>, IDeepCloneable<TrapDefenseRefreshGainingGroupResponse>, IBufferMessage
	{
		// Token: 0x0601C189 RID: 115081 RVA: 0x00413FBA File Offset: 0x004121BA
		[NullableContext(1)]
		public static TrapDefenseRefreshGainingGroupResponse Create()
		{
			return new TrapDefenseRefreshGainingGroupResponse();
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x0601C18A RID: 115082 RVA: 0x00413FC1 File Offset: 0x004121C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x0601C18B RID: 115083 RVA: 0x00413FC4 File Offset: 0x004121C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshGainingGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601C18C RID: 115084 RVA: 0x00413FCB File Offset: 0x004121CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse()
		{
		}

		// Token: 0x0601C18D RID: 115085 RVA: 0x00413FD4 File Offset: 0x004121D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse(TrapDefenseRefreshGainingGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newRewardInfo_ = ((other.newRewardInfo_ != null) ? other.newRewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C18E RID: 115086 RVA: 0x00414020 File Offset: 0x00412220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupResponse Clone()
		{
			return new TrapDefenseRefreshGainingGroupResponse(this);
		}

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x0601C18F RID: 115087 RVA: 0x00414028 File Offset: 0x00412228
		// (set) Token: 0x0601C190 RID: 115088 RVA: 0x00414030 File Offset: 0x00412230
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

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x0601C191 RID: 115089 RVA: 0x00414039 File Offset: 0x00412239
		// (set) Token: 0x0601C192 RID: 115090 RVA: 0x00414041 File Offset: 0x00412241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardGainingPanelInfo NewRewardInfo
		{
			get
			{
				return this.newRewardInfo_;
			}
			set
			{
				this.newRewardInfo_ = value;
			}
		}

		// Token: 0x0601C193 RID: 115091 RVA: 0x0041404A File Offset: 0x0041224A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshGainingGroupResponse);
		}

		// Token: 0x0601C194 RID: 115092 RVA: 0x00414058 File Offset: 0x00412258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshGainingGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewRewardInfo, other.NewRewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C195 RID: 115093 RVA: 0x004140A8 File Offset: 0x004122A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.newRewardInfo_ != null)
			{
				num ^= this.NewRewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C196 RID: 115094 RVA: 0x00414103 File Offset: 0x00412303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C197 RID: 115095 RVA: 0x00414110 File Offset: 0x00412310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C198 RID: 115096 RVA: 0x0041411C File Offset: 0x0041231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newRewardInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NewRewardInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C199 RID: 115097 RVA: 0x00414178 File Offset: 0x00412378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.newRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewRewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C19A RID: 115098 RVA: 0x004141D0 File Offset: 0x004123D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshGainingGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.newRewardInfo_ != null)
			{
				if (this.newRewardInfo_ == null)
				{
					this.NewRewardInfo = new RewardGainingPanelInfo();
				}
				this.NewRewardInfo.MergeFrom(other.NewRewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C19B RID: 115099 RVA: 0x00414238 File Offset: 0x00412438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C19C RID: 115100 RVA: 0x00414244 File Offset: 0x00412444
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
				if (num != 42U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.newRewardInfo_ == null)
					{
						this.NewRewardInfo = new RewardGainingPanelInfo();
					}
					input.ReadMessage(this.NewRewardInfo);
				}
			}
		}

		// Token: 0x0400A292 RID: 41618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A293 RID: 41619
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A294 RID: 41620
		private ErrorCode errorCode_;

		// Token: 0x0400A295 RID: 41621
		public const int NewRewardInfoFieldNumber = 5;

		// Token: 0x0400A296 RID: 41622
		private RewardGainingPanelInfo newRewardInfo_;
	}
}
