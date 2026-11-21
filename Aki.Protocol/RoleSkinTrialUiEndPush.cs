using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B3 RID: 4275
	[NetMessage(EMessageId.RoleSkinTrialUiEndPush)]
	public sealed class RoleSkinTrialUiEndPush : IMessage<RoleSkinTrialUiEndPush>, IMessage, IEquatable<RoleSkinTrialUiEndPush>, IDeepCloneable<RoleSkinTrialUiEndPush>, IBufferMessage
	{
		// Token: 0x06016D86 RID: 93574 RVA: 0x00351E43 File Offset: 0x00350043
		[NullableContext(1)]
		public static RoleSkinTrialUiEndPush Create()
		{
			return new RoleSkinTrialUiEndPush();
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x06016D87 RID: 93575 RVA: 0x00351E4A File Offset: 0x0035004A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x06016D88 RID: 93576 RVA: 0x00351E4D File Offset: 0x0035004D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialUiEndPush.Descriptor;
			}
		}

		// Token: 0x06016D89 RID: 93577 RVA: 0x00351E54 File Offset: 0x00350054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush()
		{
		}

		// Token: 0x06016D8A RID: 93578 RVA: 0x00351E5C File Offset: 0x0035005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush(RoleSkinTrialUiEndPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D8B RID: 93579 RVA: 0x00351E75 File Offset: 0x00350075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush Clone()
		{
			return new RoleSkinTrialUiEndPush(this);
		}

		// Token: 0x06016D8C RID: 93580 RVA: 0x00351E7D File Offset: 0x0035007D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialUiEndPush);
		}

		// Token: 0x06016D8D RID: 93581 RVA: 0x00351E8B File Offset: 0x0035008B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialUiEndPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016D8E RID: 93582 RVA: 0x00351EAC File Offset: 0x003500AC
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

		// Token: 0x06016D8F RID: 93583 RVA: 0x00351ED2 File Offset: 0x003500D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D90 RID: 93584 RVA: 0x00351EDF File Offset: 0x003500DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D91 RID: 93585 RVA: 0x00351EE8 File Offset: 0x003500E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D92 RID: 93586 RVA: 0x00351F00 File Offset: 0x00350100
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

		// Token: 0x06016D93 RID: 93587 RVA: 0x00351F26 File Offset: 0x00350126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialUiEndPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D94 RID: 93588 RVA: 0x00351F43 File Offset: 0x00350143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D95 RID: 93589 RVA: 0x00351F4C File Offset: 0x0035014C
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

		// Token: 0x040088AD RID: 34989
		private UnknownFieldSet _unknownFields;
	}
}
