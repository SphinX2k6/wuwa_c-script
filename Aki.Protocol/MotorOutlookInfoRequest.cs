using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A78 RID: 2680
	[NetMessage(EMessageId.MotorOutlookInfoRequest)]
	public sealed class MotorOutlookInfoRequest : IMessage<MotorOutlookInfoRequest>, IMessage, IEquatable<MotorOutlookInfoRequest>, IDeepCloneable<MotorOutlookInfoRequest>, IBufferMessage
	{
		// Token: 0x0600E9D9 RID: 59865 RVA: 0x002229CB File Offset: 0x00220BCB
		[NullableContext(1)]
		public static MotorOutlookInfoRequest Create()
		{
			return new MotorOutlookInfoRequest();
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600E9DA RID: 59866 RVA: 0x002229D2 File Offset: 0x00220BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x002229D5 File Offset: 0x00220BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600E9DC RID: 59868 RVA: 0x002229DC File Offset: 0x00220BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest()
		{
		}

		// Token: 0x0600E9DD RID: 59869 RVA: 0x002229E4 File Offset: 0x00220BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest(MotorOutlookInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9DE RID: 59870 RVA: 0x002229FD File Offset: 0x00220BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest Clone()
		{
			return new MotorOutlookInfoRequest(this);
		}

		// Token: 0x0600E9DF RID: 59871 RVA: 0x00222A05 File Offset: 0x00220C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookInfoRequest);
		}

		// Token: 0x0600E9E0 RID: 59872 RVA: 0x00222A13 File Offset: 0x00220C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x00222A34 File Offset: 0x00220C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x00222A5A File Offset: 0x00220C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x00222A67 File Offset: 0x00220C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x00222A70 File Offset: 0x00220C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x00222A88 File Offset: 0x00220C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x00222AAE File Offset: 0x00220CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x00222ACB File Offset: 0x00220CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x00222AD4 File Offset: 0x00220CD4
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F65 RID: 24421
		private UnknownFieldSet _unknownFields;
	}
}
