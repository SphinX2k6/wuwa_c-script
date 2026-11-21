using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001172 RID: 4466
	[NetMessage(EMessageId.RTimeStopInstRequest)]
	public sealed class RTimeStopInstRequest : IMessage<RTimeStopInstRequest>, IMessage, IEquatable<RTimeStopInstRequest>, IDeepCloneable<RTimeStopInstRequest>, IBufferMessage
	{
		// Token: 0x06017DC5 RID: 97733 RVA: 0x003793BC File Offset: 0x003775BC
		[NullableContext(1)]
		public static RTimeStopInstRequest Create()
		{
			return new RTimeStopInstRequest();
		}

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x06017DC6 RID: 97734 RVA: 0x003793C3 File Offset: 0x003775C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x06017DC7 RID: 97735 RVA: 0x003793C6 File Offset: 0x003775C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstRequest.Descriptor;
			}
		}

		// Token: 0x06017DC8 RID: 97736 RVA: 0x003793CD File Offset: 0x003775CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest()
		{
		}

		// Token: 0x06017DC9 RID: 97737 RVA: 0x003793D5 File Offset: 0x003775D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest(RTimeStopInstRequest other) : this()
		{
			this.flag_ = other.flag_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DCA RID: 97738 RVA: 0x00379406 File Offset: 0x00377606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest Clone()
		{
			return new RTimeStopInstRequest(this);
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x06017DCB RID: 97739 RVA: 0x0037940E File Offset: 0x0037760E
		// (set) Token: 0x06017DCC RID: 97740 RVA: 0x00379416 File Offset: 0x00377616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x06017DCD RID: 97741 RVA: 0x0037941F File Offset: 0x0037761F
		// (set) Token: 0x06017DCE RID: 97742 RVA: 0x00379427 File Offset: 0x00377627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x06017DCF RID: 97743 RVA: 0x00379430 File Offset: 0x00377630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstRequest);
		}

		// Token: 0x06017DD0 RID: 97744 RVA: 0x0037943E File Offset: 0x0037763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstRequest other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DD1 RID: 97745 RVA: 0x0037947C File Offset: 0x0037767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017DD2 RID: 97746 RVA: 0x003794D4 File Offset: 0x003776D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DD3 RID: 97747 RVA: 0x003794E1 File Offset: 0x003776E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DD4 RID: 97748 RVA: 0x003794EC File Offset: 0x003776EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Duration);
			}
			if (this.Flag)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DD5 RID: 97749 RVA: 0x00379548 File Offset: 0x00377748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Flag)
			{
				num += 2;
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017DD6 RID: 97750 RVA: 0x00379594 File Offset: 0x00377794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017DD7 RID: 97751 RVA: 0x003795E4 File Offset: 0x003777E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x003795F0 File Offset: 0x003777F0
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
				if (num != 80U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Flag = input.ReadBool();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E49 RID: 36425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E4A RID: 36426
		public const int FlagFieldNumber = 13;

		// Token: 0x04008E4B RID: 36427
		private bool flag_;

		// Token: 0x04008E4C RID: 36428
		public const int DurationFieldNumber = 10;

		// Token: 0x04008E4D RID: 36429
		private int duration_;
	}
}
