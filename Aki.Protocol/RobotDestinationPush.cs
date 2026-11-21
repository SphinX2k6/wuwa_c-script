using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6A RID: 3946
	[NetMessage(EMessageId.RobotDestinationPush)]
	public sealed class RobotDestinationPush : IMessage<RobotDestinationPush>, IMessage, IEquatable<RobotDestinationPush>, IDeepCloneable<RobotDestinationPush>, IBufferMessage
	{
		// Token: 0x06015201 RID: 86529 RVA: 0x00310BB4 File Offset: 0x0030EDB4
		[NullableContext(1)]
		public static RobotDestinationPush Create()
		{
			return new RobotDestinationPush();
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x06015202 RID: 86530 RVA: 0x00310BBB File Offset: 0x0030EDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x06015203 RID: 86531 RVA: 0x00310BBE File Offset: 0x0030EDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RobotDestinationPush.Descriptor;
			}
		}

		// Token: 0x06015204 RID: 86532 RVA: 0x00310BC5 File Offset: 0x0030EDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush()
		{
		}

		// Token: 0x06015205 RID: 86533 RVA: 0x00310BCD File Offset: 0x0030EDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush(RobotDestinationPush other) : this()
		{
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015206 RID: 86534 RVA: 0x00310C02 File Offset: 0x0030EE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush Clone()
		{
			return new RobotDestinationPush(this);
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x06015207 RID: 86535 RVA: 0x00310C0A File Offset: 0x0030EE0A
		// (set) Token: 0x06015208 RID: 86536 RVA: 0x00310C12 File Offset: 0x0030EE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06015209 RID: 86537 RVA: 0x00310C1B File Offset: 0x0030EE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RobotDestinationPush);
		}

		// Token: 0x0601520A RID: 86538 RVA: 0x00310C29 File Offset: 0x0030EE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RobotDestinationPush other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601520B RID: 86539 RVA: 0x00310C5C File Offset: 0x0030EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601520C RID: 86540 RVA: 0x00310C98 File Offset: 0x0030EE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601520D RID: 86541 RVA: 0x00310CA5 File Offset: 0x0030EEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601520E RID: 86542 RVA: 0x00310CAE File Offset: 0x0030EEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601520F RID: 86543 RVA: 0x00310CE0 File Offset: 0x0030EEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015210 RID: 86544 RVA: 0x00310D20 File Offset: 0x0030EF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RobotDestinationPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015211 RID: 86545 RVA: 0x00310D74 File Offset: 0x0030EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015212 RID: 86546 RVA: 0x00310D80 File Offset: 0x0030EF80
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.location_ == null)
					{
						this.Location = new Vector();
					}
					input.ReadMessage(this.Location);
				}
			}
		}

		// Token: 0x04007F8B RID: 32651
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F8C RID: 32652
		public const int LocationFieldNumber = 3;

		// Token: 0x04007F8D RID: 32653
		private Vector location_;
	}
}
