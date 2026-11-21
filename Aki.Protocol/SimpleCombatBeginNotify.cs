using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001259 RID: 4697
	[NetMessage(EMessageId.SimpleCombatBeginNotify)]
	public sealed class SimpleCombatBeginNotify : IMessage<SimpleCombatBeginNotify>, IMessage, IEquatable<SimpleCombatBeginNotify>, IDeepCloneable<SimpleCombatBeginNotify>, IBufferMessage
	{
		// Token: 0x0601912D RID: 102701 RVA: 0x003A79E3 File Offset: 0x003A5BE3
		[NullableContext(1)]
		public static SimpleCombatBeginNotify Create()
		{
			return new SimpleCombatBeginNotify();
		}

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x0601912E RID: 102702 RVA: 0x003A79EA File Offset: 0x003A5BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x0601912F RID: 102703 RVA: 0x003A79ED File Offset: 0x003A5BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatBeginNotify.Descriptor;
			}
		}

		// Token: 0x06019130 RID: 102704 RVA: 0x003A79F4 File Offset: 0x003A5BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify()
		{
		}

		// Token: 0x06019131 RID: 102705 RVA: 0x003A79FC File Offset: 0x003A5BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify(SimpleCombatBeginNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019132 RID: 102706 RVA: 0x003A7A15 File Offset: 0x003A5C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify Clone()
		{
			return new SimpleCombatBeginNotify(this);
		}

		// Token: 0x06019133 RID: 102707 RVA: 0x003A7A1D File Offset: 0x003A5C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatBeginNotify);
		}

		// Token: 0x06019134 RID: 102708 RVA: 0x003A7A2B File Offset: 0x003A5C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatBeginNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019135 RID: 102709 RVA: 0x003A7A4C File Offset: 0x003A5C4C
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

		// Token: 0x06019136 RID: 102710 RVA: 0x003A7A72 File Offset: 0x003A5C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019137 RID: 102711 RVA: 0x003A7A7F File Offset: 0x003A5C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019138 RID: 102712 RVA: 0x003A7A88 File Offset: 0x003A5C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019139 RID: 102713 RVA: 0x003A7AA0 File Offset: 0x003A5CA0
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

		// Token: 0x0601913A RID: 102714 RVA: 0x003A7AC6 File Offset: 0x003A5CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatBeginNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601913B RID: 102715 RVA: 0x003A7AE3 File Offset: 0x003A5CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601913C RID: 102716 RVA: 0x003A7AEC File Offset: 0x003A5CEC
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

		// Token: 0x0400948A RID: 38026
		private UnknownFieldSet _unknownFields;
	}
}
