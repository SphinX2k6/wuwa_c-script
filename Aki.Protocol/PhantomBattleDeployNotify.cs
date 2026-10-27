using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7B RID: 3195
	[NetMessage(EMessageId.PhantomBattleDeployNotify)]
	public sealed class PhantomBattleDeployNotify : IMessage<PhantomBattleDeployNotify>, IMessage, IEquatable<PhantomBattleDeployNotify>, IDeepCloneable<PhantomBattleDeployNotify>, IBufferMessage
	{
		// Token: 0x06011516 RID: 70934 RVA: 0x002891D8 File Offset: 0x002873D8
		[NullableContext(1)]
		public static PhantomBattleDeployNotify Create()
		{
			return new PhantomBattleDeployNotify();
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x06011517 RID: 70935 RVA: 0x002891DF File Offset: 0x002873DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x06011518 RID: 70936 RVA: 0x002891E2 File Offset: 0x002873E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDeployNotify.Descriptor;
			}
		}

		// Token: 0x06011519 RID: 70937 RVA: 0x002891E9 File Offset: 0x002873E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify()
		{
		}

		// Token: 0x0601151A RID: 70938 RVA: 0x002891F1 File Offset: 0x002873F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify(PhantomBattleDeployNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601151B RID: 70939 RVA: 0x0028920A File Offset: 0x0028740A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDeployNotify Clone()
		{
			return new PhantomBattleDeployNotify(this);
		}

		// Token: 0x0601151C RID: 70940 RVA: 0x00289212 File Offset: 0x00287412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDeployNotify);
		}

		// Token: 0x0601151D RID: 70941 RVA: 0x00289220 File Offset: 0x00287420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDeployNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601151E RID: 70942 RVA: 0x00289240 File Offset: 0x00287440
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

		// Token: 0x0601151F RID: 70943 RVA: 0x00289266 File Offset: 0x00287466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011520 RID: 70944 RVA: 0x00289273 File Offset: 0x00287473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011521 RID: 70945 RVA: 0x0028927C File Offset: 0x0028747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x00289294 File Offset: 0x00287494
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

		// Token: 0x06011523 RID: 70947 RVA: 0x002892BA File Offset: 0x002874BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDeployNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x002892D7 File Offset: 0x002874D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011525 RID: 70949 RVA: 0x002892E0 File Offset: 0x002874E0
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

		// Token: 0x04006D7D RID: 28029
		private UnknownFieldSet _unknownFields;
	}
}
