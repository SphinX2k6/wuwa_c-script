using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B5 RID: 5301
	public sealed class TrapDefenseRewardStepPbData : IMessage<TrapDefenseRewardStepPbData>, IMessage, IEquatable<TrapDefenseRewardStepPbData>, IDeepCloneable<TrapDefenseRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0601C211 RID: 115217 RVA: 0x00415792 File Offset: 0x00413992
		[NullableContext(1)]
		public static TrapDefenseRewardStepPbData Create()
		{
			return new TrapDefenseRewardStepPbData();
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x0601C212 RID: 115218 RVA: 0x00415799 File Offset: 0x00413999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x0601C213 RID: 115219 RVA: 0x0041579C File Offset: 0x0041399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x004157A3 File Offset: 0x004139A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData()
		{
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x004157AB File Offset: 0x004139AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData(TrapDefenseRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x004157C4 File Offset: 0x004139C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData Clone()
		{
			return new TrapDefenseRewardStepPbData(this);
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x004157CC File Offset: 0x004139CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardStepPbData);
		}

		// Token: 0x0601C218 RID: 115224 RVA: 0x004157DA File Offset: 0x004139DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C219 RID: 115225 RVA: 0x004157F8 File Offset: 0x004139F8
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

		// Token: 0x0601C21A RID: 115226 RVA: 0x0041581E File Offset: 0x00413A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C21B RID: 115227 RVA: 0x0041582B File Offset: 0x00413A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C21C RID: 115228 RVA: 0x00415834 File Offset: 0x00413A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C21D RID: 115229 RVA: 0x0041584C File Offset: 0x00413A4C
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

		// Token: 0x0601C21E RID: 115230 RVA: 0x00415872 File Offset: 0x00413A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C21F RID: 115231 RVA: 0x0041588F File Offset: 0x00413A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C220 RID: 115232 RVA: 0x00415898 File Offset: 0x00413A98
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

		// Token: 0x0400A2CC RID: 41676
		private UnknownFieldSet _unknownFields;
	}
}
