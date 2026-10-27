using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001356 RID: 4950
	[NetMessage(EMessageId.TetrisUpdateRequest)]
	public sealed class TetrisUpdateRequest : IMessage<TetrisUpdateRequest>, IMessage, IEquatable<TetrisUpdateRequest>, IDeepCloneable<TetrisUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601A4CF RID: 107727 RVA: 0x003D23B5 File Offset: 0x003D05B5
		[NullableContext(1)]
		public static TetrisUpdateRequest Create()
		{
			return new TetrisUpdateRequest();
		}

		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x0601A4D0 RID: 107728 RVA: 0x003D23BC File Offset: 0x003D05BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x0601A4D1 RID: 107729 RVA: 0x003D23BF File Offset: 0x003D05BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601A4D2 RID: 107730 RVA: 0x003D23C6 File Offset: 0x003D05C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest()
		{
		}

		// Token: 0x0601A4D3 RID: 107731 RVA: 0x003D23D0 File Offset: 0x003D05D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest(TetrisUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.tetrisLevelInfo_ = ((other.tetrisLevelInfo_ != null) ? other.tetrisLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4D4 RID: 107732 RVA: 0x003D241C File Offset: 0x003D061C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest Clone()
		{
			return new TetrisUpdateRequest(this);
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x0601A4D5 RID: 107733 RVA: 0x003D2424 File Offset: 0x003D0624
		// (set) Token: 0x0601A4D6 RID: 107734 RVA: 0x003D242C File Offset: 0x003D062C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x0601A4D7 RID: 107735 RVA: 0x003D2435 File Offset: 0x003D0635
		// (set) Token: 0x0601A4D8 RID: 107736 RVA: 0x003D243D File Offset: 0x003D063D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo TetrisLevelInfo
		{
			get
			{
				return this.tetrisLevelInfo_;
			}
			set
			{
				this.tetrisLevelInfo_ = value;
			}
		}

		// Token: 0x0601A4D9 RID: 107737 RVA: 0x003D2446 File Offset: 0x003D0646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisUpdateRequest);
		}

		// Token: 0x0601A4DA RID: 107738 RVA: 0x003D2454 File Offset: 0x003D0654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.TetrisLevelInfo, other.TetrisLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4DB RID: 107739 RVA: 0x003D24A4 File Offset: 0x003D06A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.tetrisLevelInfo_ != null)
			{
				num ^= this.TetrisLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4DC RID: 107740 RVA: 0x003D24F9 File Offset: 0x003D06F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4DD RID: 107741 RVA: 0x003D2506 File Offset: 0x003D0706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4DE RID: 107742 RVA: 0x003D2510 File Offset: 0x003D0710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tetrisLevelInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TetrisLevelInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4DF RID: 107743 RVA: 0x003D256C File Offset: 0x003D076C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.tetrisLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TetrisLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4E0 RID: 107744 RVA: 0x003D25C4 File Offset: 0x003D07C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.tetrisLevelInfo_ != null)
			{
				if (this.tetrisLevelInfo_ == null)
				{
					this.TetrisLevelInfo = new TetrisLevelInfo();
				}
				this.TetrisLevelInfo.MergeFrom(other.TetrisLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x003D262C File Offset: 0x003D082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x003D2638 File Offset: 0x003D0838
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
				if (num != 50U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.tetrisLevelInfo_ == null)
					{
						this.TetrisLevelInfo = new TetrisLevelInfo();
					}
					input.ReadMessage(this.TetrisLevelInfo);
				}
			}
		}

		// Token: 0x04009962 RID: 39266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009963 RID: 39267
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04009964 RID: 39268
		private int activityId_;

		// Token: 0x04009965 RID: 39269
		public const int TetrisLevelInfoFieldNumber = 6;

		// Token: 0x04009966 RID: 39270
		private TetrisLevelInfo tetrisLevelInfo_;
	}
}
