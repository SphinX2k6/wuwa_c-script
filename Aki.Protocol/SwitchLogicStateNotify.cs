using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FF RID: 4863
	[NetMessage(EMessageId.SwitchLogicStateNotify)]
	public sealed class SwitchLogicStateNotify : IMessage<SwitchLogicStateNotify>, IMessage, IEquatable<SwitchLogicStateNotify>, IDeepCloneable<SwitchLogicStateNotify>, IBufferMessage
	{
		// Token: 0x06019DA0 RID: 105888 RVA: 0x003C1A77 File Offset: 0x003BFC77
		[NullableContext(1)]
		public static SwitchLogicStateNotify Create()
		{
			return new SwitchLogicStateNotify();
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x06019DA1 RID: 105889 RVA: 0x003C1A7E File Offset: 0x003BFC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x06019DA2 RID: 105890 RVA: 0x003C1A81 File Offset: 0x003BFC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateNotify.Descriptor;
			}
		}

		// Token: 0x06019DA3 RID: 105891 RVA: 0x003C1A88 File Offset: 0x003BFC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify()
		{
		}

		// Token: 0x06019DA4 RID: 105892 RVA: 0x003C1A90 File Offset: 0x003BFC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify(SwitchLogicStateNotify other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DA5 RID: 105893 RVA: 0x003C1AC5 File Offset: 0x003BFCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateNotify Clone()
		{
			return new SwitchLogicStateNotify(this);
		}

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x06019DA6 RID: 105894 RVA: 0x003C1ACD File Offset: 0x003BFCCD
		// (set) Token: 0x06019DA7 RID: 105895 RVA: 0x003C1AD5 File Offset: 0x003BFCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb States
		{
			get
			{
				return this.states_;
			}
			set
			{
				this.states_ = value;
			}
		}

		// Token: 0x06019DA8 RID: 105896 RVA: 0x003C1ADE File Offset: 0x003BFCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateNotify);
		}

		// Token: 0x06019DA9 RID: 105897 RVA: 0x003C1AEC File Offset: 0x003BFCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DAA RID: 105898 RVA: 0x003C1B20 File Offset: 0x003BFD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.states_ != null)
			{
				num ^= this.States.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019DAB RID: 105899 RVA: 0x003C1B5C File Offset: 0x003BFD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DAC RID: 105900 RVA: 0x003C1B69 File Offset: 0x003BFD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DAD RID: 105901 RVA: 0x003C1B72 File Offset: 0x003BFD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.states_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.States);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DAE RID: 105902 RVA: 0x003C1BA4 File Offset: 0x003BFDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.states_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.States);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019DAF RID: 105903 RVA: 0x003C1BE4 File Offset: 0x003BFDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.states_ != null)
			{
				if (this.states_ == null)
				{
					this.States = new LogicStateComponentPb();
				}
				this.States.MergeFrom(other.States);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019DB0 RID: 105904 RVA: 0x003C1C38 File Offset: 0x003BFE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DB1 RID: 105905 RVA: 0x003C1C44 File Offset: 0x003BFE44
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.states_ == null)
					{
						this.States = new LogicStateComponentPb();
					}
					input.ReadMessage(this.States);
				}
			}
		}

		// Token: 0x04009732 RID: 38706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009733 RID: 38707
		public const int StatesFieldNumber = 8;

		// Token: 0x04009734 RID: 38708
		private LogicStateComponentPb states_;
	}
}
