using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000425 RID: 1061
	public sealed class EdgeRunnerLordGymPassRecord : IMessage<EdgeRunnerLordGymPassRecord>, IMessage, IEquatable<EdgeRunnerLordGymPassRecord>, IDeepCloneable<EdgeRunnerLordGymPassRecord>, IBufferMessage
	{
		// Token: 0x060065FB RID: 26107 RVA: 0x000F5782 File Offset: 0x000F3982
		[NullableContext(1)]
		public static EdgeRunnerLordGymPassRecord Create()
		{
			return new EdgeRunnerLordGymPassRecord();
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x000F5789 File Offset: 0x000F3989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EdgeRunnerLordGymPassRecord> Parser
		{
			get
			{
				return EdgeRunnerLordGymPassRecord._parser;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x000F5790 File Offset: 0x000F3990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x000F5793 File Offset: 0x000F3993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymPassRecord.Descriptor;
			}
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x000F579A File Offset: 0x000F399A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord()
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x000F57A2 File Offset: 0x000F39A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord(EdgeRunnerLordGymPassRecord other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x000F57D3 File Offset: 0x000F39D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymPassRecord Clone()
		{
			return new EdgeRunnerLordGymPassRecord(this);
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06006602 RID: 26114 RVA: 0x000F57DB File Offset: 0x000F39DB
		// (set) Token: 0x06006603 RID: 26115 RVA: 0x000F57E3 File Offset: 0x000F39E3
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

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06006604 RID: 26116 RVA: 0x000F57EC File Offset: 0x000F39EC
		// (set) Token: 0x06006605 RID: 26117 RVA: 0x000F57F4 File Offset: 0x000F39F4
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

		// Token: 0x06006606 RID: 26118 RVA: 0x000F57FD File Offset: 0x000F39FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymPassRecord);
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x000F580B File Offset: 0x000F3A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymPassRecord other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x000F584C File Offset: 0x000F3A4C
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

		// Token: 0x06006609 RID: 26121 RVA: 0x000F58A4 File Offset: 0x000F3AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x000F58B1 File Offset: 0x000F3AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x000F58BC File Offset: 0x000F3ABC
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

		// Token: 0x0600660C RID: 26124 RVA: 0x000F5914 File Offset: 0x000F3B14
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

		// Token: 0x0600660D RID: 26125 RVA: 0x000F596C File Offset: 0x000F3B6C
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

		// Token: 0x0600660E RID: 26126 RVA: 0x000F59BC File Offset: 0x000F3BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x000F59C8 File Offset: 0x000F3BC8
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

		// Token: 0x04003909 RID: 14601
		private static readonly MessageParser<EdgeRunnerLordGymPassRecord> _parser = new MessageParser<EdgeRunnerLordGymPassRecord>(() => new EdgeRunnerLordGymPassRecord());

		// Token: 0x0400390A RID: 14602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400390B RID: 14603
		public const int LoadGymIdFieldNumber = 1;

		// Token: 0x0400390C RID: 14604
		private int loadGymId_;

		// Token: 0x0400390D RID: 14605
		public const int PassTimeFieldNumber = 2;

		// Token: 0x0400390E RID: 14606
		private int passTime_;
	}
}
