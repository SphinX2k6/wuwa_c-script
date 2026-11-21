using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F69 RID: 3945
	[NetMessage(EMessageId.RobotDestinationNotify)]
	public sealed class RobotDestinationNotify : IMessage<RobotDestinationNotify>, IMessage, IEquatable<RobotDestinationNotify>, IDeepCloneable<RobotDestinationNotify>, IBufferMessage
	{
		// Token: 0x060151EF RID: 86511 RVA: 0x0031098E File Offset: 0x0030EB8E
		[NullableContext(1)]
		public static RobotDestinationNotify Create()
		{
			return new RobotDestinationNotify();
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x060151F0 RID: 86512 RVA: 0x00310995 File Offset: 0x0030EB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x060151F1 RID: 86513 RVA: 0x00310998 File Offset: 0x0030EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RobotDestinationNotify.Descriptor;
			}
		}

		// Token: 0x060151F2 RID: 86514 RVA: 0x0031099F File Offset: 0x0030EB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify()
		{
		}

		// Token: 0x060151F3 RID: 86515 RVA: 0x003109A7 File Offset: 0x0030EBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify(RobotDestinationNotify other) : this()
		{
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151F4 RID: 86516 RVA: 0x003109DC File Offset: 0x0030EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RobotDestinationNotify Clone()
		{
			return new RobotDestinationNotify(this);
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x060151F5 RID: 86517 RVA: 0x003109E4 File Offset: 0x0030EBE4
		// (set) Token: 0x060151F6 RID: 86518 RVA: 0x003109EC File Offset: 0x0030EBEC
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

		// Token: 0x060151F7 RID: 86519 RVA: 0x003109F5 File Offset: 0x0030EBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RobotDestinationNotify);
		}

		// Token: 0x060151F8 RID: 86520 RVA: 0x00310A03 File Offset: 0x0030EC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RobotDestinationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151F9 RID: 86521 RVA: 0x00310A38 File Offset: 0x0030EC38
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

		// Token: 0x060151FA RID: 86522 RVA: 0x00310A74 File Offset: 0x0030EC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151FB RID: 86523 RVA: 0x00310A81 File Offset: 0x0030EC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151FC RID: 86524 RVA: 0x00310A8A File Offset: 0x0030EC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151FD RID: 86525 RVA: 0x00310ABC File Offset: 0x0030ECBC
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

		// Token: 0x060151FE RID: 86526 RVA: 0x00310AFC File Offset: 0x0030ECFC
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

		// Token: 0x060151FF RID: 86527 RVA: 0x00310B50 File Offset: 0x0030ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015200 RID: 86528 RVA: 0x00310B5C File Offset: 0x0030ED5C
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
				if (num != 42U)
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

		// Token: 0x04007F88 RID: 32648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F89 RID: 32649
		public const int LocationFieldNumber = 5;

		// Token: 0x04007F8A RID: 32650
		private Vector location_;
	}
}
