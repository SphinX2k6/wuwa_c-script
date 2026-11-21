using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7F RID: 3967
	public sealed class RoguelikeActivityData : IMessage<RoguelikeActivityData>, IMessage, IEquatable<RoguelikeActivityData>, IDeepCloneable<RoguelikeActivityData>, IBufferMessage
	{
		// Token: 0x060153ED RID: 87021 RVA: 0x00315C99 File Offset: 0x00313E99
		[NullableContext(1)]
		public static RoguelikeActivityData Create()
		{
			return new RoguelikeActivityData();
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x060153EE RID: 87022 RVA: 0x00315CA0 File Offset: 0x00313EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x060153EF RID: 87023 RVA: 0x00315CA3 File Offset: 0x00313EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeActivityData.Descriptor;
			}
		}

		// Token: 0x060153F0 RID: 87024 RVA: 0x00315CAA File Offset: 0x00313EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData()
		{
		}

		// Token: 0x060153F1 RID: 87025 RVA: 0x00315CB4 File Offset: 0x00313EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData(RoguelikeActivityData other) : this()
		{
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this.rogueSeasonData_ = ((other.rogueSeasonData_ != null) ? other.rogueSeasonData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060153F2 RID: 87026 RVA: 0x00315D0C File Offset: 0x00313F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData Clone()
		{
			return new RoguelikeActivityData(this);
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x060153F3 RID: 87027 RVA: 0x00315D14 File Offset: 0x00313F14
		// (set) Token: 0x060153F4 RID: 87028 RVA: 0x00315D1C File Offset: 0x00313F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x060153F5 RID: 87029 RVA: 0x00315D25 File Offset: 0x00313F25
		// (set) Token: 0x060153F6 RID: 87030 RVA: 0x00315D2D File Offset: 0x00313F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndOpenTime
		{
			get
			{
				return this.endOpenTime_;
			}
			set
			{
				this.endOpenTime_ = value;
			}
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x060153F7 RID: 87031 RVA: 0x00315D36 File Offset: 0x00313F36
		// (set) Token: 0x060153F8 RID: 87032 RVA: 0x00315D3E File Offset: 0x00313F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData RogueSeasonData
		{
			get
			{
				return this.rogueSeasonData_;
			}
			set
			{
				this.rogueSeasonData_ = value;
			}
		}

		// Token: 0x060153F9 RID: 87033 RVA: 0x00315D47 File Offset: 0x00313F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeActivityData);
		}

		// Token: 0x060153FA RID: 87034 RVA: 0x00315D58 File Offset: 0x00313F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeActivityData other)
		{
			return other != null && (other == this || (this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this.RogueSeasonData, other.RogueSeasonData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153FB RID: 87035 RVA: 0x00315DB8 File Offset: 0x00313FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this.EndOpenTime != 0L)
			{
				num ^= this.EndOpenTime.GetHashCode();
			}
			if (this.rogueSeasonData_ != null)
			{
				num ^= this.RogueSeasonData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060153FC RID: 87036 RVA: 0x00315E26 File Offset: 0x00314026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153FD RID: 87037 RVA: 0x00315E33 File Offset: 0x00314033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153FE RID: 87038 RVA: 0x00315E3C File Offset: 0x0031403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndOpenTime);
			}
			if (this.rogueSeasonData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueSeasonData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060153FF RID: 87039 RVA: 0x00315EB0 File Offset: 0x003140B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndOpenTime);
			}
			if (this.rogueSeasonData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueSeasonData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015400 RID: 87040 RVA: 0x00315F20 File Offset: 0x00314120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			if (other.EndOpenTime != 0L)
			{
				this.EndOpenTime = other.EndOpenTime;
			}
			if (other.rogueSeasonData_ != null)
			{
				if (this.rogueSeasonData_ == null)
				{
					this.RogueSeasonData = new RogueSeasonData();
				}
				this.RogueSeasonData.MergeFrom(other.RogueSeasonData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015401 RID: 87041 RVA: 0x00315F9C File Offset: 0x0031419C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015402 RID: 87042 RVA: 0x00315FA8 File Offset: 0x003141A8
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueSeasonData_ == null)
							{
								this.RogueSeasonData = new RogueSeasonData();
							}
							input.ReadMessage(this.RogueSeasonData);
						}
					}
					else
					{
						this.EndOpenTime = input.ReadInt64();
					}
				}
				else
				{
					this.BeginOpenTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008054 RID: 32852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008055 RID: 32853
		public const int BeginOpenTimeFieldNumber = 1;

		// Token: 0x04008056 RID: 32854
		private long beginOpenTime_;

		// Token: 0x04008057 RID: 32855
		public const int EndOpenTimeFieldNumber = 2;

		// Token: 0x04008058 RID: 32856
		private long endOpenTime_;

		// Token: 0x04008059 RID: 32857
		public const int RogueSeasonDataFieldNumber = 3;

		// Token: 0x0400805A RID: 32858
		private RogueSeasonData rogueSeasonData_;
	}
}
