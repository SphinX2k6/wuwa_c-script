using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A2 RID: 5282
	public sealed class TrapDefenseMapChangeStepPbData : IMessage<TrapDefenseMapChangeStepPbData>, IMessage, IEquatable<TrapDefenseMapChangeStepPbData>, IDeepCloneable<TrapDefenseMapChangeStepPbData>, IBufferMessage
	{
		// Token: 0x0601C090 RID: 114832 RVA: 0x00412299 File Offset: 0x00410499
		[NullableContext(1)]
		public static TrapDefenseMapChangeStepPbData Create()
		{
			return new TrapDefenseMapChangeStepPbData();
		}

		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x0601C091 RID: 114833 RVA: 0x004122A0 File Offset: 0x004104A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x0601C092 RID: 114834 RVA: 0x004122A3 File Offset: 0x004104A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMapChangeStepPbData.Descriptor;
			}
		}

		// Token: 0x0601C093 RID: 114835 RVA: 0x004122AA File Offset: 0x004104AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData()
		{
		}

		// Token: 0x0601C094 RID: 114836 RVA: 0x004122B2 File Offset: 0x004104B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData(TrapDefenseMapChangeStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C095 RID: 114837 RVA: 0x004122CB File Offset: 0x004104CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData Clone()
		{
			return new TrapDefenseMapChangeStepPbData(this);
		}

		// Token: 0x0601C096 RID: 114838 RVA: 0x004122D3 File Offset: 0x004104D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMapChangeStepPbData);
		}

		// Token: 0x0601C097 RID: 114839 RVA: 0x004122E1 File Offset: 0x004104E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMapChangeStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C098 RID: 114840 RVA: 0x00412300 File Offset: 0x00410500
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

		// Token: 0x0601C099 RID: 114841 RVA: 0x00412326 File Offset: 0x00410526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C09A RID: 114842 RVA: 0x00412333 File Offset: 0x00410533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C09B RID: 114843 RVA: 0x0041233C File Offset: 0x0041053C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C09C RID: 114844 RVA: 0x00412354 File Offset: 0x00410554
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

		// Token: 0x0601C09D RID: 114845 RVA: 0x0041237A File Offset: 0x0041057A
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

		// Token: 0x0601C09E RID: 114846 RVA: 0x00412397 File Offset: 0x00410597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C09F RID: 114847 RVA: 0x004123A0 File Offset: 0x004105A0
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

		// Token: 0x0400A25A RID: 41562
		private UnknownFieldSet _unknownFields;
	}
}
