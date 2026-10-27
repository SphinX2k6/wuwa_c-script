using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001442 RID: 5186
	public sealed class TrapDefenseRewardStepPbData : IMessage<TrapDefenseRewardStepPbData>, IMessage, IEquatable<TrapDefenseRewardStepPbData>, IDeepCloneable<TrapDefenseRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0601B786 RID: 112518 RVA: 0x003FA4BE File Offset: 0x003F86BE
		[NullableContext(1)]
		public static TrapDefenseRewardStepPbData Create()
		{
			return new TrapDefenseRewardStepPbData();
		}

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x0601B787 RID: 112519 RVA: 0x003FA4C5 File Offset: 0x003F86C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x0601B788 RID: 112520 RVA: 0x003FA4C8 File Offset: 0x003F86C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0601B789 RID: 112521 RVA: 0x003FA4CF File Offset: 0x003F86CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData()
		{
		}

		// Token: 0x0601B78A RID: 112522 RVA: 0x003FA4D7 File Offset: 0x003F86D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData(TrapDefenseRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B78B RID: 112523 RVA: 0x003FA4F0 File Offset: 0x003F86F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData Clone()
		{
			return new TrapDefenseRewardStepPbData(this);
		}

		// Token: 0x0601B78C RID: 112524 RVA: 0x003FA4F8 File Offset: 0x003F86F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardStepPbData);
		}

		// Token: 0x0601B78D RID: 112525 RVA: 0x003FA506 File Offset: 0x003F8706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B78E RID: 112526 RVA: 0x003FA524 File Offset: 0x003F8724
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

		// Token: 0x0601B78F RID: 112527 RVA: 0x003FA54A File Offset: 0x003F874A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B790 RID: 112528 RVA: 0x003FA557 File Offset: 0x003F8757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B791 RID: 112529 RVA: 0x003FA560 File Offset: 0x003F8760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B792 RID: 112530 RVA: 0x003FA578 File Offset: 0x003F8778
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

		// Token: 0x0601B793 RID: 112531 RVA: 0x003FA59E File Offset: 0x003F879E
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

		// Token: 0x0601B794 RID: 112532 RVA: 0x003FA5BB File Offset: 0x003F87BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B795 RID: 112533 RVA: 0x003FA5C4 File Offset: 0x003F87C4
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

		// Token: 0x04009E85 RID: 40581
		private UnknownFieldSet _unknownFields;
	}
}
