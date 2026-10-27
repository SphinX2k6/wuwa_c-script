using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8F RID: 3983
	public sealed class RoguelikeActivityData : IMessage<RoguelikeActivityData>, IMessage, IEquatable<RoguelikeActivityData>, IDeepCloneable<RoguelikeActivityData>, IBufferMessage
	{
		// Token: 0x060154D2 RID: 87250 RVA: 0x0031734D File Offset: 0x0031554D
		[NullableContext(1)]
		public static RoguelikeActivityData Create()
		{
			return new RoguelikeActivityData();
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x060154D3 RID: 87251 RVA: 0x00317354 File Offset: 0x00315554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x060154D4 RID: 87252 RVA: 0x00317357 File Offset: 0x00315557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeActivityData.Descriptor;
			}
		}

		// Token: 0x060154D5 RID: 87253 RVA: 0x0031735E File Offset: 0x0031555E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData()
		{
		}

		// Token: 0x060154D6 RID: 87254 RVA: 0x00317368 File Offset: 0x00315568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData(RoguelikeActivityData other) : this()
		{
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this.rogueSeasonData_ = ((other.rogueSeasonData_ != null) ? other.rogueSeasonData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060154D7 RID: 87255 RVA: 0x003173C0 File Offset: 0x003155C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeActivityData Clone()
		{
			return new RoguelikeActivityData(this);
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x060154D8 RID: 87256 RVA: 0x003173C8 File Offset: 0x003155C8
		// (set) Token: 0x060154D9 RID: 87257 RVA: 0x003173D0 File Offset: 0x003155D0
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

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x060154DA RID: 87258 RVA: 0x003173D9 File Offset: 0x003155D9
		// (set) Token: 0x060154DB RID: 87259 RVA: 0x003173E1 File Offset: 0x003155E1
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

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x060154DC RID: 87260 RVA: 0x003173EA File Offset: 0x003155EA
		// (set) Token: 0x060154DD RID: 87261 RVA: 0x003173F2 File Offset: 0x003155F2
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

		// Token: 0x060154DE RID: 87262 RVA: 0x003173FB File Offset: 0x003155FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeActivityData);
		}

		// Token: 0x060154DF RID: 87263 RVA: 0x0031740C File Offset: 0x0031560C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeActivityData other)
		{
			return other != null && (other == this || (this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this.RogueSeasonData, other.RogueSeasonData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154E0 RID: 87264 RVA: 0x0031746C File Offset: 0x0031566C
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

		// Token: 0x060154E1 RID: 87265 RVA: 0x003174DA File Offset: 0x003156DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154E2 RID: 87266 RVA: 0x003174E7 File Offset: 0x003156E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154E3 RID: 87267 RVA: 0x003174F0 File Offset: 0x003156F0
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

		// Token: 0x060154E4 RID: 87268 RVA: 0x00317564 File Offset: 0x00315764
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

		// Token: 0x060154E5 RID: 87269 RVA: 0x003175D4 File Offset: 0x003157D4
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

		// Token: 0x060154E6 RID: 87270 RVA: 0x00317650 File Offset: 0x00315850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154E7 RID: 87271 RVA: 0x0031765C File Offset: 0x0031585C
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

		// Token: 0x0400802A RID: 32810
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400802B RID: 32811
		public const int BeginOpenTimeFieldNumber = 1;

		// Token: 0x0400802C RID: 32812
		private long beginOpenTime_;

		// Token: 0x0400802D RID: 32813
		public const int EndOpenTimeFieldNumber = 2;

		// Token: 0x0400802E RID: 32814
		private long endOpenTime_;

		// Token: 0x0400802F RID: 32815
		public const int RogueSeasonDataFieldNumber = 3;

		// Token: 0x04008030 RID: 32816
		private RogueSeasonData rogueSeasonData_;
	}
}
