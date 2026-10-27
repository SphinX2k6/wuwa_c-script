using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F79 RID: 3961
	[NetMessage(EMessageId.RobotDestinationNotify)]
	public sealed class RobotDestinationNotify : IMessage<RobotDestinationNotify>, IMessage, IEquatable<RobotDestinationNotify>, IDeepCloneable<RobotDestinationNotify>, IBufferMessage
	{
		// Token: 0x060152D4 RID: 86740 RVA: 0x0031203A File Offset: 0x0031023A
		[NullableContext(1)]
		public static RobotDestinationNotify Create()
		{
			return new RobotDestinationNotify();
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x060152D5 RID: 86741 RVA: 0x00312041 File Offset: 0x00310241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x060152D6 RID: 86742 RVA: 0x00312044 File Offset: 0x00310244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RobotDestinationNotify.Descriptor;
			}
		}

		// Token: 0x060152D7 RID: 86743 RVA: 0x0031204B File Offset: 0x0031024B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify()
		{
		}

		// Token: 0x060152D8 RID: 86744 RVA: 0x00312053 File Offset: 0x00310253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify(RobotDestinationNotify other) : this()
		{
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152D9 RID: 86745 RVA: 0x00312088 File Offset: 0x00310288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify Clone()
		{
			return new RobotDestinationNotify(this);
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x060152DA RID: 86746 RVA: 0x00312090 File Offset: 0x00310290
		// (set) Token: 0x060152DB RID: 86747 RVA: 0x00312098 File Offset: 0x00310298
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

		// Token: 0x060152DC RID: 86748 RVA: 0x003120A1 File Offset: 0x003102A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RobotDestinationNotify);
		}

		// Token: 0x060152DD RID: 86749 RVA: 0x003120AF File Offset: 0x003102AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RobotDestinationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152DE RID: 86750 RVA: 0x003120E4 File Offset: 0x003102E4
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

		// Token: 0x060152DF RID: 86751 RVA: 0x00312120 File Offset: 0x00310320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152E0 RID: 86752 RVA: 0x0031212D File Offset: 0x0031032D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152E1 RID: 86753 RVA: 0x00312136 File Offset: 0x00310336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152E2 RID: 86754 RVA: 0x00312168 File Offset: 0x00310368
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

		// Token: 0x060152E3 RID: 86755 RVA: 0x003121A8 File Offset: 0x003103A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RobotDestinationNotify other)
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

		// Token: 0x060152E4 RID: 86756 RVA: 0x003121FC File Offset: 0x003103FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152E5 RID: 86757 RVA: 0x00312208 File Offset: 0x00310408
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
				if (num != 82U)
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

		// Token: 0x04007F5E RID: 32606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F5F RID: 32607
		public const int LocationFieldNumber = 10;

		// Token: 0x04007F60 RID: 32608
		private Vector location_;
	}
}
