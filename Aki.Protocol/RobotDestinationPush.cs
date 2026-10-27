using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7A RID: 3962
	[NetMessage(EMessageId.RobotDestinationPush)]
	public sealed class RobotDestinationPush : IMessage<RobotDestinationPush>, IMessage, IEquatable<RobotDestinationPush>, IDeepCloneable<RobotDestinationPush>, IBufferMessage
	{
		// Token: 0x060152E6 RID: 86758 RVA: 0x00312260 File Offset: 0x00310460
		[NullableContext(1)]
		public static RobotDestinationPush Create()
		{
			return new RobotDestinationPush();
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x060152E7 RID: 86759 RVA: 0x00312267 File Offset: 0x00310467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x060152E8 RID: 86760 RVA: 0x0031226A File Offset: 0x0031046A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RobotDestinationPush.Descriptor;
			}
		}

		// Token: 0x060152E9 RID: 86761 RVA: 0x00312271 File Offset: 0x00310471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush()
		{
		}

		// Token: 0x060152EA RID: 86762 RVA: 0x00312279 File Offset: 0x00310479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush(RobotDestinationPush other) : this()
		{
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152EB RID: 86763 RVA: 0x003122AE File Offset: 0x003104AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationPush Clone()
		{
			return new RobotDestinationPush(this);
		}

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x060152EC RID: 86764 RVA: 0x003122B6 File Offset: 0x003104B6
		// (set) Token: 0x060152ED RID: 86765 RVA: 0x003122BE File Offset: 0x003104BE
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

		// Token: 0x060152EE RID: 86766 RVA: 0x003122C7 File Offset: 0x003104C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RobotDestinationPush);
		}

		// Token: 0x060152EF RID: 86767 RVA: 0x003122D5 File Offset: 0x003104D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RobotDestinationPush other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152F0 RID: 86768 RVA: 0x00312308 File Offset: 0x00310508
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

		// Token: 0x060152F1 RID: 86769 RVA: 0x00312344 File Offset: 0x00310544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152F2 RID: 86770 RVA: 0x00312351 File Offset: 0x00310551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152F3 RID: 86771 RVA: 0x0031235A File Offset: 0x0031055A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152F4 RID: 86772 RVA: 0x0031238C File Offset: 0x0031058C
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

		// Token: 0x060152F5 RID: 86773 RVA: 0x003123CC File Offset: 0x003105CC
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

		// Token: 0x060152F6 RID: 86774 RVA: 0x00312420 File Offset: 0x00310620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x0031242C File Offset: 0x0031062C
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
				if (num != 34U)
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

		// Token: 0x04007F61 RID: 32609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F62 RID: 32610
		public const int LocationFieldNumber = 4;

		// Token: 0x04007F63 RID: 32611
		private Vector location_;
	}
}
