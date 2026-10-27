using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D50 RID: 3408
	public sealed class PinballKSCRolePbData : IMessage<PinballKSCRolePbData>, IMessage, IEquatable<PinballKSCRolePbData>, IDeepCloneable<PinballKSCRolePbData>, IBufferMessage
	{
		// Token: 0x06012622 RID: 75298 RVA: 0x002AEB93 File Offset: 0x002ACD93
		[NullableContext(1)]
		public static PinballKSCRolePbData Create()
		{
			return new PinballKSCRolePbData();
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x06012623 RID: 75299 RVA: 0x002AEB9A File Offset: 0x002ACD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x06012624 RID: 75300 RVA: 0x002AEB9D File Offset: 0x002ACD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballKSCRolePbData.Descriptor;
			}
		}

		// Token: 0x06012625 RID: 75301 RVA: 0x002AEBA4 File Offset: 0x002ACDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData()
		{
		}

		// Token: 0x06012626 RID: 75302 RVA: 0x002AEBAC File Offset: 0x002ACDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData(PinballKSCRolePbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012627 RID: 75303 RVA: 0x002AEBC5 File Offset: 0x002ACDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData Clone()
		{
			return new PinballKSCRolePbData(this);
		}

		// Token: 0x06012628 RID: 75304 RVA: 0x002AEBCD File Offset: 0x002ACDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballKSCRolePbData);
		}

		// Token: 0x06012629 RID: 75305 RVA: 0x002AEBDB File Offset: 0x002ACDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballKSCRolePbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601262A RID: 75306 RVA: 0x002AEBFC File Offset: 0x002ACDFC
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

		// Token: 0x0601262B RID: 75307 RVA: 0x002AEC22 File Offset: 0x002ACE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601262C RID: 75308 RVA: 0x002AEC2F File Offset: 0x002ACE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601262D RID: 75309 RVA: 0x002AEC38 File Offset: 0x002ACE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601262E RID: 75310 RVA: 0x002AEC50 File Offset: 0x002ACE50
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

		// Token: 0x0601262F RID: 75311 RVA: 0x002AEC76 File Offset: 0x002ACE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballKSCRolePbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012630 RID: 75312 RVA: 0x002AEC93 File Offset: 0x002ACE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012631 RID: 75313 RVA: 0x002AEC9C File Offset: 0x002ACE9C
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

		// Token: 0x0400727D RID: 29309
		private UnknownFieldSet _unknownFields;
	}
}
