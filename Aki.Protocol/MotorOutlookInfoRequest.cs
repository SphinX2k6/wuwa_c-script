using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A89 RID: 2697
	[NetMessage(EMessageId.MotorOutlookInfoRequest)]
	public sealed class MotorOutlookInfoRequest : IMessage<MotorOutlookInfoRequest>, IMessage, IEquatable<MotorOutlookInfoRequest>, IDeepCloneable<MotorOutlookInfoRequest>, IBufferMessage
	{
		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00224BC7 File Offset: 0x00222DC7
		[NullableContext(1)]
		public static MotorOutlookInfoRequest Create()
		{
			return new MotorOutlookInfoRequest();
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600EAF4 RID: 60148 RVA: 0x00224BCE File Offset: 0x00222DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x00224BD1 File Offset: 0x00222DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600EAF6 RID: 60150 RVA: 0x00224BD8 File Offset: 0x00222DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest()
		{
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x00224BE0 File Offset: 0x00222DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest(MotorOutlookInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x00224BF9 File Offset: 0x00222DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookInfoRequest Clone()
		{
			return new MotorOutlookInfoRequest(this);
		}

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x00224C01 File Offset: 0x00222E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookInfoRequest);
		}

		// Token: 0x0600EAFA RID: 60154 RVA: 0x00224C0F File Offset: 0x00222E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x00224C30 File Offset: 0x00222E30
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

		// Token: 0x0600EAFC RID: 60156 RVA: 0x00224C56 File Offset: 0x00222E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x00224C63 File Offset: 0x00222E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAFE RID: 60158 RVA: 0x00224C6C File Offset: 0x00222E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAFF RID: 60159 RVA: 0x00224C84 File Offset: 0x00222E84
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

		// Token: 0x0600EB00 RID: 60160 RVA: 0x00224CAA File Offset: 0x00222EAA
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

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00224CC7 File Offset: 0x00222EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00224CD0 File Offset: 0x00222ED0
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

		// Token: 0x04005F5C RID: 24412
		private UnknownFieldSet _unknownFields;
	}
}
