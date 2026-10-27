using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001042 RID: 4162
	public sealed class RogueWeeklyPlayData : IMessage<RogueWeeklyPlayData>, IMessage, IEquatable<RogueWeeklyPlayData>, IDeepCloneable<RogueWeeklyPlayData>, IBufferMessage
	{
		// Token: 0x060163D7 RID: 91095 RVA: 0x0033B17F File Offset: 0x0033937F
		[NullableContext(1)]
		public static RogueWeeklyPlayData Create()
		{
			return new RogueWeeklyPlayData();
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x060163D8 RID: 91096 RVA: 0x0033B186 File Offset: 0x00339386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x060163D9 RID: 91097 RVA: 0x0033B189 File Offset: 0x00339389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyPlayData.Descriptor;
			}
		}

		// Token: 0x060163DA RID: 91098 RVA: 0x0033B190 File Offset: 0x00339390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData()
		{
		}

		// Token: 0x060163DB RID: 91099 RVA: 0x0033B198 File Offset: 0x00339398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData(RogueWeeklyPlayData other) : this()
		{
			this.hasRecord_ = other.hasRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163DC RID: 91100 RVA: 0x0033B1BD File Offset: 0x003393BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData Clone()
		{
			return new RogueWeeklyPlayData(this);
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x060163DD RID: 91101 RVA: 0x0033B1C5 File Offset: 0x003393C5
		// (set) Token: 0x060163DE RID: 91102 RVA: 0x0033B1CD File Offset: 0x003393CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasRecord
		{
			get
			{
				return this.hasRecord_;
			}
			set
			{
				this.hasRecord_ = value;
			}
		}

		// Token: 0x060163DF RID: 91103 RVA: 0x0033B1D6 File Offset: 0x003393D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyPlayData);
		}

		// Token: 0x060163E0 RID: 91104 RVA: 0x0033B1E4 File Offset: 0x003393E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyPlayData other)
		{
			return other != null && (other == this || (this.HasRecord == other.HasRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163E1 RID: 91105 RVA: 0x0033B214 File Offset: 0x00339414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasRecord)
			{
				num ^= this.HasRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060163E2 RID: 91106 RVA: 0x0033B253 File Offset: 0x00339453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163E3 RID: 91107 RVA: 0x0033B260 File Offset: 0x00339460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163E4 RID: 91108 RVA: 0x0033B269 File Offset: 0x00339469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasRecord)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060163E5 RID: 91109 RVA: 0x0033B29C File Offset: 0x0033949C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasRecord)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060163E6 RID: 91110 RVA: 0x0033B2CE File Offset: 0x003394CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyPlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasRecord)
			{
				this.HasRecord = other.HasRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060163E7 RID: 91111 RVA: 0x0033B2FF File Offset: 0x003394FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163E8 RID: 91112 RVA: 0x0033B308 File Offset: 0x00339508
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HasRecord = input.ReadBool();
				}
			}
		}

		// Token: 0x0400850D RID: 34061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400850E RID: 34062
		public const int HasRecordFieldNumber = 1;

		// Token: 0x0400850F RID: 34063
		private bool hasRecord_;
	}
}
