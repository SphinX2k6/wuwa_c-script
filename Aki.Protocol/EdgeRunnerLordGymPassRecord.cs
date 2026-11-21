using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040E RID: 1038
	public sealed class EdgeRunnerLordGymPassRecord : IMessage<EdgeRunnerLordGymPassRecord>, IMessage, IEquatable<EdgeRunnerLordGymPassRecord>, IDeepCloneable<EdgeRunnerLordGymPassRecord>, IBufferMessage
	{
		// Token: 0x0600646B RID: 25707 RVA: 0x000F2611 File Offset: 0x000F0811
		[NullableContext(1)]
		public static EdgeRunnerLordGymPassRecord Create()
		{
			return new EdgeRunnerLordGymPassRecord();
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x000F2618 File Offset: 0x000F0818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EdgeRunnerLordGymPassRecord> Parser
		{
			get
			{
				return EdgeRunnerLordGymPassRecord._parser;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x0600646D RID: 25709 RVA: 0x000F261F File Offset: 0x000F081F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x000F2622 File Offset: 0x000F0822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymPassRecord.Descriptor;
			}
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x000F2629 File Offset: 0x000F0829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord()
		{
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x000F2631 File Offset: 0x000F0831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord(EdgeRunnerLordGymPassRecord other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x000F2662 File Offset: 0x000F0862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord Clone()
		{
			return new EdgeRunnerLordGymPassRecord(this);
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x000F266A File Offset: 0x000F086A
		// (set) Token: 0x06006473 RID: 25715 RVA: 0x000F2672 File Offset: 0x000F0872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x000F267B File Offset: 0x000F087B
		// (set) Token: 0x06006475 RID: 25717 RVA: 0x000F2683 File Offset: 0x000F0883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x000F268C File Offset: 0x000F088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymPassRecord);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x000F269A File Offset: 0x000F089A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymPassRecord other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x000F26D8 File Offset: 0x000F08D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x000F2730 File Offset: 0x000F0930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x000F273D File Offset: 0x000F093D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x000F2748 File Offset: 0x000F0948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoadGymId);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x000F27A0 File Offset: 0x000F09A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x000F27F8 File Offset: 0x000F09F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerLordGymPassRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x000F2848 File Offset: 0x000F0A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x000F2854 File Offset: 0x000F0A54
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PassTime = input.ReadInt32();
					}
				}
				else
				{
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040038F6 RID: 14582
		private static readonly MessageParser<EdgeRunnerLordGymPassRecord> _parser = new MessageParser<EdgeRunnerLordGymPassRecord>(() => new EdgeRunnerLordGymPassRecord());

		// Token: 0x040038F7 RID: 14583
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F8 RID: 14584
		public const int LoadGymIdFieldNumber = 1;

		// Token: 0x040038F9 RID: 14585
		private int loadGymId_;

		// Token: 0x040038FA RID: 14586
		public const int PassTimeFieldNumber = 2;

		// Token: 0x040038FB RID: 14587
		private int passTime_;
	}
}
