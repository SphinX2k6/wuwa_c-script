using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2A RID: 3114
	[NetMessage(EMessageId.PhantomBattleBurnBuffNotify)]
	public sealed class PhantomBattleBurnBuffNotify : IMessage<PhantomBattleBurnBuffNotify>, IMessage, IEquatable<PhantomBattleBurnBuffNotify>, IDeepCloneable<PhantomBattleBurnBuffNotify>, IBufferMessage
	{
		// Token: 0x06010E9C RID: 69276 RVA: 0x0027A665 File Offset: 0x00278865
		[NullableContext(1)]
		public static PhantomBattleBurnBuffNotify Create()
		{
			return new PhantomBattleBurnBuffNotify();
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x06010E9D RID: 69277 RVA: 0x0027A66C File Offset: 0x0027886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x06010E9E RID: 69278 RVA: 0x0027A66F File Offset: 0x0027886F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBurnBuffNotify.Descriptor;
			}
		}

		// Token: 0x06010E9F RID: 69279 RVA: 0x0027A676 File Offset: 0x00278876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify()
		{
		}

		// Token: 0x06010EA0 RID: 69280 RVA: 0x0027A67E File Offset: 0x0027887E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify(PhantomBattleBurnBuffNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EA1 RID: 69281 RVA: 0x0027A697 File Offset: 0x00278897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify Clone()
		{
			return new PhantomBattleBurnBuffNotify(this);
		}

		// Token: 0x06010EA2 RID: 69282 RVA: 0x0027A69F File Offset: 0x0027889F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBurnBuffNotify);
		}

		// Token: 0x06010EA3 RID: 69283 RVA: 0x0027A6AD File Offset: 0x002788AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBurnBuffNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010EA4 RID: 69284 RVA: 0x0027A6CC File Offset: 0x002788CC
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

		// Token: 0x06010EA5 RID: 69285 RVA: 0x0027A6F2 File Offset: 0x002788F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EA6 RID: 69286 RVA: 0x0027A6FF File Offset: 0x002788FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EA7 RID: 69287 RVA: 0x0027A708 File Offset: 0x00278908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EA8 RID: 69288 RVA: 0x0027A720 File Offset: 0x00278920
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

		// Token: 0x06010EA9 RID: 69289 RVA: 0x0027A746 File Offset: 0x00278946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBurnBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010EAA RID: 69290 RVA: 0x0027A763 File Offset: 0x00278963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EAB RID: 69291 RVA: 0x0027A76C File Offset: 0x0027896C
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

		// Token: 0x04006BB2 RID: 27570
		private UnknownFieldSet _unknownFields;
	}
}
