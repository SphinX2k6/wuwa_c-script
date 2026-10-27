using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3A RID: 3130
	[NetMessage(EMessageId.PhantomBattleBurnBuffNotify)]
	public sealed class PhantomBattleBurnBuffNotify : IMessage<PhantomBattleBurnBuffNotify>, IMessage, IEquatable<PhantomBattleBurnBuffNotify>, IDeepCloneable<PhantomBattleBurnBuffNotify>, IBufferMessage
	{
		// Token: 0x06010F9C RID: 69532 RVA: 0x0027C3C5 File Offset: 0x0027A5C5
		[NullableContext(1)]
		public static PhantomBattleBurnBuffNotify Create()
		{
			return new PhantomBattleBurnBuffNotify();
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x06010F9D RID: 69533 RVA: 0x0027C3CC File Offset: 0x0027A5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x06010F9E RID: 69534 RVA: 0x0027C3CF File Offset: 0x0027A5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBurnBuffNotify.Descriptor;
			}
		}

		// Token: 0x06010F9F RID: 69535 RVA: 0x0027C3D6 File Offset: 0x0027A5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify()
		{
		}

		// Token: 0x06010FA0 RID: 69536 RVA: 0x0027C3DE File Offset: 0x0027A5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify(PhantomBattleBurnBuffNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FA1 RID: 69537 RVA: 0x0027C3F7 File Offset: 0x0027A5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBurnBuffNotify Clone()
		{
			return new PhantomBattleBurnBuffNotify(this);
		}

		// Token: 0x06010FA2 RID: 69538 RVA: 0x0027C3FF File Offset: 0x0027A5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBurnBuffNotify);
		}

		// Token: 0x06010FA3 RID: 69539 RVA: 0x0027C40D File Offset: 0x0027A60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBurnBuffNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010FA4 RID: 69540 RVA: 0x0027C42C File Offset: 0x0027A62C
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

		// Token: 0x06010FA5 RID: 69541 RVA: 0x0027C452 File Offset: 0x0027A652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FA6 RID: 69542 RVA: 0x0027C45F File Offset: 0x0027A65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FA7 RID: 69543 RVA: 0x0027C468 File Offset: 0x0027A668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FA8 RID: 69544 RVA: 0x0027C480 File Offset: 0x0027A680
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

		// Token: 0x06010FA9 RID: 69545 RVA: 0x0027C4A6 File Offset: 0x0027A6A6
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

		// Token: 0x06010FAA RID: 69546 RVA: 0x0027C4C3 File Offset: 0x0027A6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FAB RID: 69547 RVA: 0x0027C4CC File Offset: 0x0027A6CC
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

		// Token: 0x04006B9E RID: 27550
		private UnknownFieldSet _unknownFields;
	}
}
