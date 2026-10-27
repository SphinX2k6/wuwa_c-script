using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CF RID: 4303
	[NetMessage(EMessageId.RoleTrialUiEndPush)]
	public sealed class RoleTrialUiEndPush : IMessage<RoleTrialUiEndPush>, IMessage, IEquatable<RoleTrialUiEndPush>, IDeepCloneable<RoleTrialUiEndPush>, IBufferMessage
	{
		// Token: 0x06016F58 RID: 94040 RVA: 0x00355374 File Offset: 0x00353574
		[NullableContext(1)]
		public static RoleTrialUiEndPush Create()
		{
			return new RoleTrialUiEndPush();
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x06016F59 RID: 94041 RVA: 0x0035537B File Offset: 0x0035357B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x06016F5A RID: 94042 RVA: 0x0035537E File Offset: 0x0035357E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialUiEndPush.Descriptor;
			}
		}

		// Token: 0x06016F5B RID: 94043 RVA: 0x00355385 File Offset: 0x00353585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush()
		{
		}

		// Token: 0x06016F5C RID: 94044 RVA: 0x0035538D File Offset: 0x0035358D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush(RoleTrialUiEndPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F5D RID: 94045 RVA: 0x003553A6 File Offset: 0x003535A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialUiEndPush Clone()
		{
			return new RoleTrialUiEndPush(this);
		}

		// Token: 0x06016F5E RID: 94046 RVA: 0x003553AE File Offset: 0x003535AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialUiEndPush);
		}

		// Token: 0x06016F5F RID: 94047 RVA: 0x003553BC File Offset: 0x003535BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialUiEndPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016F60 RID: 94048 RVA: 0x003553DC File Offset: 0x003535DC
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

		// Token: 0x06016F61 RID: 94049 RVA: 0x00355402 File Offset: 0x00353602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F62 RID: 94050 RVA: 0x0035540F File Offset: 0x0035360F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F63 RID: 94051 RVA: 0x00355418 File Offset: 0x00353618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F64 RID: 94052 RVA: 0x00355430 File Offset: 0x00353630
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

		// Token: 0x06016F65 RID: 94053 RVA: 0x00355456 File Offset: 0x00353656
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

		// Token: 0x06016F66 RID: 94054 RVA: 0x00355473 File Offset: 0x00353673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F67 RID: 94055 RVA: 0x0035547C File Offset: 0x0035367C
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

		// Token: 0x040088C5 RID: 35013
		private UnknownFieldSet _unknownFields;
	}
}
