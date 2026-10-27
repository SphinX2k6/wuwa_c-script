using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A87 RID: 2695
	[NetMessage(EMessageId.MotorOutlookFullChangeNotify)]
	public sealed class MotorOutlookFullChangeNotify : IMessage<MotorOutlookFullChangeNotify>, IMessage, IEquatable<MotorOutlookFullChangeNotify>, IDeepCloneable<MotorOutlookFullChangeNotify>, IBufferMessage
	{
		// Token: 0x0600EACB RID: 60107 RVA: 0x002246EB File Offset: 0x002228EB
		[NullableContext(1)]
		public static MotorOutlookFullChangeNotify Create()
		{
			return new MotorOutlookFullChangeNotify();
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0600EACC RID: 60108 RVA: 0x002246F2 File Offset: 0x002228F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600EACD RID: 60109 RVA: 0x002246F5 File Offset: 0x002228F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookFullChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x002246FC File Offset: 0x002228FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify()
		{
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x00224704 File Offset: 0x00222904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify(MotorOutlookFullChangeNotify other) : this()
		{
			this.motorOutlook_ = ((other.motorOutlook_ != null) ? other.motorOutlook_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00224739 File Offset: 0x00222939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookFullChangeNotify Clone()
		{
			return new MotorOutlookFullChangeNotify(this);
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600EAD1 RID: 60113 RVA: 0x00224741 File Offset: 0x00222941
		// (set) Token: 0x0600EAD2 RID: 60114 RVA: 0x00224749 File Offset: 0x00222949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb MotorOutlook
		{
			get
			{
				return this.motorOutlook_;
			}
			set
			{
				this.motorOutlook_ = value;
			}
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x00224752 File Offset: 0x00222952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookFullChangeNotify);
		}

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x00224760 File Offset: 0x00222960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookFullChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlook, other.MotorOutlook) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x00224794 File Offset: 0x00222994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlook_ != null)
			{
				num ^= this.MotorOutlook.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x002247D0 File Offset: 0x002229D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x002247DD File Offset: 0x002229DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x002247E6 File Offset: 0x002229E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlook_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00224818 File Offset: 0x00222A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlook_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlook);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x00224858 File Offset: 0x00222A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookFullChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlook_ != null)
			{
				if (this.motorOutlook_ == null)
				{
					this.MotorOutlook = new MotorOutlookPb();
				}
				this.MotorOutlook.MergeFrom(other.MotorOutlook);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x002248AC File Offset: 0x00222AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x002248B8 File Offset: 0x00222AB8
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.motorOutlook_ == null)
					{
						this.MotorOutlook = new MotorOutlookPb();
					}
					input.ReadMessage(this.MotorOutlook);
				}
			}
		}

		// Token: 0x04005F53 RID: 24403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F54 RID: 24404
		public const int MotorOutlookFieldNumber = 11;

		// Token: 0x04005F55 RID: 24405
		private MotorOutlookPb motorOutlook_;
	}
}
