using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2B RID: 3115
	[NetMessage(EMessageId.PhantomBattleBvBFightNotify)]
	public sealed class PhantomBattleBvBFightNotify : IMessage<PhantomBattleBvBFightNotify>, IMessage, IEquatable<PhantomBattleBvBFightNotify>, IDeepCloneable<PhantomBattleBvBFightNotify>, IBufferMessage
	{
		// Token: 0x06010EAC RID: 69292 RVA: 0x0027A79E File Offset: 0x0027899E
		[NullableContext(1)]
		public static PhantomBattleBvBFightNotify Create()
		{
			return new PhantomBattleBvBFightNotify();
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x06010EAD RID: 69293 RVA: 0x0027A7A5 File Offset: 0x002789A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x06010EAE RID: 69294 RVA: 0x0027A7A8 File Offset: 0x002789A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBFightNotify.Descriptor;
			}
		}

		// Token: 0x06010EAF RID: 69295 RVA: 0x0027A7AF File Offset: 0x002789AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify()
		{
		}

		// Token: 0x06010EB0 RID: 69296 RVA: 0x0027A7B7 File Offset: 0x002789B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify(PhantomBattleBvBFightNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EB1 RID: 69297 RVA: 0x0027A7D0 File Offset: 0x002789D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify Clone()
		{
			return new PhantomBattleBvBFightNotify(this);
		}

		// Token: 0x06010EB2 RID: 69298 RVA: 0x0027A7D8 File Offset: 0x002789D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBFightNotify);
		}

		// Token: 0x06010EB3 RID: 69299 RVA: 0x0027A7E6 File Offset: 0x002789E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBFightNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010EB4 RID: 69300 RVA: 0x0027A804 File Offset: 0x00278A04
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

		// Token: 0x06010EB5 RID: 69301 RVA: 0x0027A82A File Offset: 0x00278A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EB6 RID: 69302 RVA: 0x0027A837 File Offset: 0x00278A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EB7 RID: 69303 RVA: 0x0027A840 File Offset: 0x00278A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EB8 RID: 69304 RVA: 0x0027A858 File Offset: 0x00278A58
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

		// Token: 0x06010EB9 RID: 69305 RVA: 0x0027A87E File Offset: 0x00278A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBFightNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010EBA RID: 69306 RVA: 0x0027A89B File Offset: 0x00278A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EBB RID: 69307 RVA: 0x0027A8A4 File Offset: 0x00278AA4
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

		// Token: 0x04006BB3 RID: 27571
		private UnknownFieldSet _unknownFields;
	}
}
