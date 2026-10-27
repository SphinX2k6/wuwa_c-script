using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD8 RID: 3288
	[NetMessage(EMessageId.PhantomInteractionEquipResponse)]
	public sealed class PhantomInteractionEquipResponse : IMessage<PhantomInteractionEquipResponse>, IMessage, IEquatable<PhantomInteractionEquipResponse>, IDeepCloneable<PhantomInteractionEquipResponse>, IBufferMessage
	{
		// Token: 0x06011CB3 RID: 72883 RVA: 0x0029A73D File Offset: 0x0029893D
		[NullableContext(1)]
		public static PhantomInteractionEquipResponse Create()
		{
			return new PhantomInteractionEquipResponse();
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x06011CB4 RID: 72884 RVA: 0x0029A744 File Offset: 0x00298944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x06011CB5 RID: 72885 RVA: 0x0029A747 File Offset: 0x00298947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionEquipResponse.Descriptor;
			}
		}

		// Token: 0x06011CB6 RID: 72886 RVA: 0x0029A74E File Offset: 0x0029894E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse()
		{
		}

		// Token: 0x06011CB7 RID: 72887 RVA: 0x0029A756 File Offset: 0x00298956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse(PhantomInteractionEquipResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CB8 RID: 72888 RVA: 0x0029A77B File Offset: 0x0029897B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionEquipResponse Clone()
		{
			return new PhantomInteractionEquipResponse(this);
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x06011CB9 RID: 72889 RVA: 0x0029A783 File Offset: 0x00298983
		// (set) Token: 0x06011CBA RID: 72890 RVA: 0x0029A78B File Offset: 0x0029898B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06011CBB RID: 72891 RVA: 0x0029A794 File Offset: 0x00298994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionEquipResponse);
		}

		// Token: 0x06011CBC RID: 72892 RVA: 0x0029A7A2 File Offset: 0x002989A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionEquipResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CBD RID: 72893 RVA: 0x0029A7D0 File Offset: 0x002989D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CBE RID: 72894 RVA: 0x0029A815 File Offset: 0x00298A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CBF RID: 72895 RVA: 0x0029A822 File Offset: 0x00298A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CC0 RID: 72896 RVA: 0x0029A82B File Offset: 0x00298A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CC1 RID: 72897 RVA: 0x0029A860 File Offset: 0x00298A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CC2 RID: 72898 RVA: 0x0029A89E File Offset: 0x00298A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionEquipResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CC3 RID: 72899 RVA: 0x0029A8CF File Offset: 0x00298ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CC4 RID: 72900 RVA: 0x0029A8D8 File Offset: 0x00298AD8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FC0 RID: 28608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FC1 RID: 28609
		public const int CodeFieldNumber = 13;

		// Token: 0x04006FC2 RID: 28610
		private ErrorCode code_;
	}
}
