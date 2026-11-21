using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125B RID: 4699
	[NetMessage(EMessageId.SimpleCombatEndNotify)]
	public sealed class SimpleCombatEndNotify : IMessage<SimpleCombatEndNotify>, IMessage, IEquatable<SimpleCombatEndNotify>, IDeepCloneable<SimpleCombatEndNotify>, IBufferMessage
	{
		// Token: 0x0601915B RID: 102747 RVA: 0x003A8174 File Offset: 0x003A6374
		[NullableContext(1)]
		public static SimpleCombatEndNotify Create()
		{
			return new SimpleCombatEndNotify();
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x0601915C RID: 102748 RVA: 0x003A817B File Offset: 0x003A637B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x0601915D RID: 102749 RVA: 0x003A817E File Offset: 0x003A637E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEndNotify.Descriptor;
			}
		}

		// Token: 0x0601915E RID: 102750 RVA: 0x003A8185 File Offset: 0x003A6385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify()
		{
		}

		// Token: 0x0601915F RID: 102751 RVA: 0x003A818D File Offset: 0x003A638D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify(SimpleCombatEndNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019160 RID: 102752 RVA: 0x003A81A6 File Offset: 0x003A63A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify Clone()
		{
			return new SimpleCombatEndNotify(this);
		}

		// Token: 0x06019161 RID: 102753 RVA: 0x003A81AE File Offset: 0x003A63AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEndNotify);
		}

		// Token: 0x06019162 RID: 102754 RVA: 0x003A81BC File Offset: 0x003A63BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEndNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019163 RID: 102755 RVA: 0x003A81DC File Offset: 0x003A63DC
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

		// Token: 0x06019164 RID: 102756 RVA: 0x003A8202 File Offset: 0x003A6402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019165 RID: 102757 RVA: 0x003A820F File Offset: 0x003A640F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019166 RID: 102758 RVA: 0x003A8218 File Offset: 0x003A6418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019167 RID: 102759 RVA: 0x003A8230 File Offset: 0x003A6430
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

		// Token: 0x06019168 RID: 102760 RVA: 0x003A8256 File Offset: 0x003A6456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019169 RID: 102761 RVA: 0x003A8273 File Offset: 0x003A6473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601916A RID: 102762 RVA: 0x003A827C File Offset: 0x003A647C
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

		// Token: 0x0400949E RID: 38046
		private UnknownFieldSet _unknownFields;
	}
}
