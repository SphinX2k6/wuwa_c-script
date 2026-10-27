using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AC RID: 4780
	[NetMessage(EMessageId.Summon3Request)]
	public sealed class Summon3Request : IMessage<Summon3Request>, IMessage, IEquatable<Summon3Request>, IDeepCloneable<Summon3Request>, IBufferMessage
	{
		// Token: 0x06019704 RID: 104196 RVA: 0x003B27FF File Offset: 0x003B09FF
		[NullableContext(1)]
		public static Summon3Request Create()
		{
			return new Summon3Request();
		}

		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x06019705 RID: 104197 RVA: 0x003B2806 File Offset: 0x003B0A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x06019706 RID: 104198 RVA: 0x003B2809 File Offset: 0x003B0A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon3Request.Descriptor;
			}
		}

		// Token: 0x06019707 RID: 104199 RVA: 0x003B2810 File Offset: 0x003B0A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request()
		{
		}

		// Token: 0x06019708 RID: 104200 RVA: 0x003B2818 File Offset: 0x003B0A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request(Summon3Request other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019709 RID: 104201 RVA: 0x003B2864 File Offset: 0x003B0A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request Clone()
		{
			return new Summon3Request(this);
		}

		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x0601970A RID: 104202 RVA: 0x003B286C File Offset: 0x003B0A6C
		// (set) Token: 0x0601970B RID: 104203 RVA: 0x003B2874 File Offset: 0x003B0A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerEntityId
		{
			get
			{
				return this.summonerEntityId_;
			}
			set
			{
				this.summonerEntityId_ = value;
			}
		}

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x0601970C RID: 104204 RVA: 0x003B287D File Offset: 0x003B0A7D
		// (set) Token: 0x0601970D RID: 104205 RVA: 0x003B2885 File Offset: 0x003B0A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo SummonInfo
		{
			get
			{
				return this.summonInfo_;
			}
			set
			{
				this.summonInfo_ = value;
			}
		}

		// Token: 0x0601970E RID: 104206 RVA: 0x003B288E File Offset: 0x003B0A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon3Request);
		}

		// Token: 0x0601970F RID: 104207 RVA: 0x003B289C File Offset: 0x003B0A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon3Request other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x003B28EC File Offset: 0x003B0AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerEntityId != 0L)
			{
				num ^= this.SummonerEntityId.GetHashCode();
			}
			if (this.summonInfo_ != null)
			{
				num ^= this.SummonInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019711 RID: 104209 RVA: 0x003B2941 File Offset: 0x003B0B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019712 RID: 104210 RVA: 0x003B294E File Offset: 0x003B0B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019713 RID: 104211 RVA: 0x003B2958 File Offset: 0x003B0B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.SummonerEntityId);
			}
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019714 RID: 104212 RVA: 0x003B29B4 File Offset: 0x003B0BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerEntityId);
			}
			if (this.summonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019715 RID: 104213 RVA: 0x003B2A0C File Offset: 0x003B0C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon3Request other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerEntityId != 0L)
			{
				this.SummonerEntityId = other.SummonerEntityId;
			}
			if (other.summonInfo_ != null)
			{
				if (this.summonInfo_ == null)
				{
					this.SummonInfo = new SummonRequestInfo();
				}
				this.SummonInfo.MergeFrom(other.SummonInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019716 RID: 104214 RVA: 0x003B2A74 File Offset: 0x003B0C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019717 RID: 104215 RVA: 0x003B2A80 File Offset: 0x003B0C80
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
				if (num != 40U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.summonInfo_ == null)
						{
							this.SummonInfo = new SummonRequestInfo();
						}
						input.ReadMessage(this.SummonInfo);
					}
				}
				else
				{
					this.SummonerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009553 RID: 38227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009554 RID: 38228
		public const int SummonerEntityIdFieldNumber = 5;

		// Token: 0x04009555 RID: 38229
		private long summonerEntityId_;

		// Token: 0x04009556 RID: 38230
		public const int SummonInfoFieldNumber = 6;

		// Token: 0x04009557 RID: 38231
		private SummonRequestInfo summonInfo_;
	}
}
