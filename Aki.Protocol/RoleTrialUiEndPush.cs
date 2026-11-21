using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001109 RID: 4361
	[NetMessage(EMessageId.RoleTrialUiEndPush)]
	public sealed class RoleTrialUiEndPush : IMessage<RoleTrialUiEndPush>, IMessage, IEquatable<RoleTrialUiEndPush>, IDeepCloneable<RoleTrialUiEndPush>, IBufferMessage
	{
		// Token: 0x060174F7 RID: 95479 RVA: 0x00364628 File Offset: 0x00362828
		[NullableContext(1)]
		public static RoleTrialUiEndPush Create()
		{
			return new RoleTrialUiEndPush();
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x060174F8 RID: 95480 RVA: 0x0036462F File Offset: 0x0036282F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x060174F9 RID: 95481 RVA: 0x00364632 File Offset: 0x00362832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialUiEndPush.Descriptor;
			}
		}

		// Token: 0x060174FA RID: 95482 RVA: 0x00364639 File Offset: 0x00362839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush()
		{
		}

		// Token: 0x060174FB RID: 95483 RVA: 0x00364641 File Offset: 0x00362841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush(RoleTrialUiEndPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174FC RID: 95484 RVA: 0x0036465A File Offset: 0x0036285A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush Clone()
		{
			return new RoleTrialUiEndPush(this);
		}

		// Token: 0x060174FD RID: 95485 RVA: 0x00364662 File Offset: 0x00362862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialUiEndPush);
		}

		// Token: 0x060174FE RID: 95486 RVA: 0x00364670 File Offset: 0x00362870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialUiEndPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060174FF RID: 95487 RVA: 0x00364690 File Offset: 0x00362890
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

		// Token: 0x06017500 RID: 95488 RVA: 0x003646B6 File Offset: 0x003628B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017501 RID: 95489 RVA: 0x003646C3 File Offset: 0x003628C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017502 RID: 95490 RVA: 0x003646CC File Offset: 0x003628CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017503 RID: 95491 RVA: 0x003646E4 File Offset: 0x003628E4
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

		// Token: 0x06017504 RID: 95492 RVA: 0x0036470A File Offset: 0x0036290A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialUiEndPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017505 RID: 95493 RVA: 0x00364727 File Offset: 0x00362927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017506 RID: 95494 RVA: 0x00364730 File Offset: 0x00362930
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

		// Token: 0x04008B56 RID: 35670
		private UnknownFieldSet _unknownFields;
	}
}
