using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142F RID: 5167
	public sealed class TrapDefenseMapChangeStepPbData : IMessage<TrapDefenseMapChangeStepPbData>, IMessage, IEquatable<TrapDefenseMapChangeStepPbData>, IDeepCloneable<TrapDefenseMapChangeStepPbData>, IBufferMessage
	{
		// Token: 0x0601B605 RID: 112133 RVA: 0x003F6FC5 File Offset: 0x003F51C5
		[NullableContext(1)]
		public static TrapDefenseMapChangeStepPbData Create()
		{
			return new TrapDefenseMapChangeStepPbData();
		}

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x0601B606 RID: 112134 RVA: 0x003F6FCC File Offset: 0x003F51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x0601B607 RID: 112135 RVA: 0x003F6FCF File Offset: 0x003F51CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMapChangeStepPbData.Descriptor;
			}
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x003F6FD6 File Offset: 0x003F51D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData()
		{
		}

		// Token: 0x0601B609 RID: 112137 RVA: 0x003F6FDE File Offset: 0x003F51DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData(TrapDefenseMapChangeStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B60A RID: 112138 RVA: 0x003F6FF7 File Offset: 0x003F51F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData Clone()
		{
			return new TrapDefenseMapChangeStepPbData(this);
		}

		// Token: 0x0601B60B RID: 112139 RVA: 0x003F6FFF File Offset: 0x003F51FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMapChangeStepPbData);
		}

		// Token: 0x0601B60C RID: 112140 RVA: 0x003F700D File Offset: 0x003F520D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMapChangeStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B60D RID: 112141 RVA: 0x003F702C File Offset: 0x003F522C
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

		// Token: 0x0601B60E RID: 112142 RVA: 0x003F7052 File Offset: 0x003F5252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B60F RID: 112143 RVA: 0x003F705F File Offset: 0x003F525F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B610 RID: 112144 RVA: 0x003F7068 File Offset: 0x003F5268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B611 RID: 112145 RVA: 0x003F7080 File Offset: 0x003F5280
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

		// Token: 0x0601B612 RID: 112146 RVA: 0x003F70A6 File Offset: 0x003F52A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMapChangeStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B613 RID: 112147 RVA: 0x003F70C3 File Offset: 0x003F52C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B614 RID: 112148 RVA: 0x003F70CC File Offset: 0x003F52CC
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

		// Token: 0x04009E13 RID: 40467
		private UnknownFieldSet _unknownFields;
	}
}
