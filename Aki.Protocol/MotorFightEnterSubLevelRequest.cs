using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2E RID: 2606
	[NetMessage(EMessageId.MotorFightEnterSubLevelRequest)]
	public sealed class MotorFightEnterSubLevelRequest : IMessage<MotorFightEnterSubLevelRequest>, IMessage, IEquatable<MotorFightEnterSubLevelRequest>, IDeepCloneable<MotorFightEnterSubLevelRequest>, IBufferMessage
	{
		// Token: 0x0600E3ED RID: 58349 RVA: 0x00215A9E File Offset: 0x00213C9E
		[NullableContext(1)]
		public static MotorFightEnterSubLevelRequest Create()
		{
			return new MotorFightEnterSubLevelRequest();
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x00215AA5 File Offset: 0x00213CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x00215AA8 File Offset: 0x00213CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightEnterSubLevelRequest.Descriptor;
			}
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x00215AAF File Offset: 0x00213CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest()
		{
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x00215AB7 File Offset: 0x00213CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest(MotorFightEnterSubLevelRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x00215ADC File Offset: 0x00213CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest Clone()
		{
			return new MotorFightEnterSubLevelRequest(this);
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x00215AE4 File Offset: 0x00213CE4
		// (set) Token: 0x0600E3F4 RID: 58356 RVA: 0x00215AEC File Offset: 0x00213CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x00215AF5 File Offset: 0x00213CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightEnterSubLevelRequest);
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x00215B03 File Offset: 0x00213D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightEnterSubLevelRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x00215B34 File Offset: 0x00213D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x00215B73 File Offset: 0x00213D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3F9 RID: 58361 RVA: 0x00215B80 File Offset: 0x00213D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x00215B89 File Offset: 0x00213D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x00215BBC File Offset: 0x00213DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x00215BFA File Offset: 0x00213DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightEnterSubLevelRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x00215C2B File Offset: 0x00213E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x00215C34 File Offset: 0x00213E34
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
					this.SubLevelIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DAE RID: 23982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DAF RID: 23983
		public const int SubLevelIndexFieldNumber = 1;

		// Token: 0x04005DB0 RID: 23984
		private int subLevelIndex_;
	}
}
