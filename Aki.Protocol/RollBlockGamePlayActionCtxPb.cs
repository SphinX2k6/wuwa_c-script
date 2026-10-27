using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D9 RID: 4313
	public sealed class RollBlockGamePlayActionCtxPb : IMessage<RollBlockGamePlayActionCtxPb>, IMessage, IEquatable<RollBlockGamePlayActionCtxPb>, IDeepCloneable<RollBlockGamePlayActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601701C RID: 94236 RVA: 0x00356AA9 File Offset: 0x00354CA9
		[NullableContext(1)]
		public static RollBlockGamePlayActionCtxPb Create()
		{
			return new RollBlockGamePlayActionCtxPb();
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x0601701D RID: 94237 RVA: 0x00356AB0 File Offset: 0x00354CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x0601701E RID: 94238 RVA: 0x00356AB3 File Offset: 0x00354CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601701F RID: 94239 RVA: 0x00356ABA File Offset: 0x00354CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb()
		{
		}

		// Token: 0x06017020 RID: 94240 RVA: 0x00356AC4 File Offset: 0x00354CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb(RollBlockGamePlayActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017021 RID: 94241 RVA: 0x00356B10 File Offset: 0x00354D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb Clone()
		{
			return new RollBlockGamePlayActionCtxPb(this);
		}

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x06017022 RID: 94242 RVA: 0x00356B18 File Offset: 0x00354D18
		// (set) Token: 0x06017023 RID: 94243 RVA: 0x00356B20 File Offset: 0x00354D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb BehaviorTreeCtx
		{
			get
			{
				return this.behaviorTreeCtx_;
			}
			set
			{
				this.behaviorTreeCtx_ = value;
			}
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x06017024 RID: 94244 RVA: 0x00356B29 File Offset: 0x00354D29
		// (set) Token: 0x06017025 RID: 94245 RVA: 0x00356B31 File Offset: 0x00354D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGameActionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06017026 RID: 94246 RVA: 0x00356B3A File Offset: 0x00354D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayActionCtxPb);
		}

		// Token: 0x06017027 RID: 94247 RVA: 0x00356B48 File Offset: 0x00354D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017028 RID: 94248 RVA: 0x00356B98 File Offset: 0x00354D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.behaviorTreeCtx_ != null)
			{
				num ^= this.BehaviorTreeCtx.GetHashCode();
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017029 RID: 94249 RVA: 0x00356BF3 File Offset: 0x00354DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601702A RID: 94250 RVA: 0x00356C00 File Offset: 0x00354E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601702B RID: 94251 RVA: 0x00356C0C File Offset: 0x00354E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.behaviorTreeCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BehaviorTreeCtx);
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601702C RID: 94252 RVA: 0x00356C68 File Offset: 0x00354E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.behaviorTreeCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTreeCtx);
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601702D RID: 94253 RVA: 0x00356CC0 File Offset: 0x00354EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.behaviorTreeCtx_ != null)
			{
				if (this.behaviorTreeCtx_ == null)
				{
					this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
				}
				this.BehaviorTreeCtx.MergeFrom(other.BehaviorTreeCtx);
			}
			if (other.Type != RollBlockGameActionType.RbMidWayExit)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601702E RID: 94254 RVA: 0x00356D28 File Offset: 0x00354F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601702F RID: 94255 RVA: 0x00356D34 File Offset: 0x00354F34
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (RollBlockGameActionType)input.ReadEnum();
					}
				}
				else
				{
					if (this.behaviorTreeCtx_ == null)
					{
						this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
					}
					input.ReadMessage(this.BehaviorTreeCtx);
				}
			}
		}

		// Token: 0x040088F1 RID: 35057
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088F2 RID: 35058
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x040088F3 RID: 35059
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x040088F4 RID: 35060
		public const int TypeFieldNumber = 2;

		// Token: 0x040088F5 RID: 35061
		private RollBlockGameActionType type_;
	}
}
