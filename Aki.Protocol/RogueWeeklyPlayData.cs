using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001032 RID: 4146
	public sealed class RogueWeeklyPlayData : IMessage<RogueWeeklyPlayData>, IMessage, IEquatable<RogueWeeklyPlayData>, IDeepCloneable<RogueWeeklyPlayData>, IBufferMessage
	{
		// Token: 0x060162F2 RID: 90866 RVA: 0x00339AAF File Offset: 0x00337CAF
		[NullableContext(1)]
		public static RogueWeeklyPlayData Create()
		{
			return new RogueWeeklyPlayData();
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x060162F3 RID: 90867 RVA: 0x00339AB6 File Offset: 0x00337CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x060162F4 RID: 90868 RVA: 0x00339AB9 File Offset: 0x00337CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyPlayData.Descriptor;
			}
		}

		// Token: 0x060162F5 RID: 90869 RVA: 0x00339AC0 File Offset: 0x00337CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData()
		{
		}

		// Token: 0x060162F6 RID: 90870 RVA: 0x00339AC8 File Offset: 0x00337CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData(RogueWeeklyPlayData other) : this()
		{
			this.hasRecord_ = other.hasRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162F7 RID: 90871 RVA: 0x00339AED File Offset: 0x00337CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData Clone()
		{
			return new RogueWeeklyPlayData(this);
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x060162F8 RID: 90872 RVA: 0x00339AF5 File Offset: 0x00337CF5
		// (set) Token: 0x060162F9 RID: 90873 RVA: 0x00339AFD File Offset: 0x00337CFD
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

		// Token: 0x060162FA RID: 90874 RVA: 0x00339B06 File Offset: 0x00337D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyPlayData);
		}

		// Token: 0x060162FB RID: 90875 RVA: 0x00339B14 File Offset: 0x00337D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyPlayData other)
		{
			return other != null && (other == this || (this.HasRecord == other.HasRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162FC RID: 90876 RVA: 0x00339B44 File Offset: 0x00337D44
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

		// Token: 0x060162FD RID: 90877 RVA: 0x00339B83 File Offset: 0x00337D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162FE RID: 90878 RVA: 0x00339B90 File Offset: 0x00337D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162FF RID: 90879 RVA: 0x00339B99 File Offset: 0x00337D99
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

		// Token: 0x06016300 RID: 90880 RVA: 0x00339BCC File Offset: 0x00337DCC
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

		// Token: 0x06016301 RID: 90881 RVA: 0x00339BFE File Offset: 0x00337DFE
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

		// Token: 0x06016302 RID: 90882 RVA: 0x00339C2F File Offset: 0x00337E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016303 RID: 90883 RVA: 0x00339C38 File Offset: 0x00337E38
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

		// Token: 0x04008537 RID: 34103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008538 RID: 34104
		public const int HasRecordFieldNumber = 1;

		// Token: 0x04008539 RID: 34105
		private bool hasRecord_;
	}
}
