using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001265 RID: 4709
	public sealed class SpecialEffectInfo : IMessage<SpecialEffectInfo>, IMessage, IEquatable<SpecialEffectInfo>, IDeepCloneable<SpecialEffectInfo>, IBufferMessage
	{
		// Token: 0x0601916E RID: 102766 RVA: 0x003A68B4 File Offset: 0x003A4AB4
		[NullableContext(1)]
		public static SpecialEffectInfo Create()
		{
			return new SpecialEffectInfo();
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x0601916F RID: 102767 RVA: 0x003A68BB File Offset: 0x003A4ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x06019170 RID: 102768 RVA: 0x003A68BE File Offset: 0x003A4ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialEffectInfo.Descriptor;
			}
		}

		// Token: 0x06019171 RID: 102769 RVA: 0x003A68C5 File Offset: 0x003A4AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo()
		{
		}

		// Token: 0x06019172 RID: 102770 RVA: 0x003A68CD File Offset: 0x003A4ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo(SpecialEffectInfo other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019173 RID: 102771 RVA: 0x003A68E6 File Offset: 0x003A4AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialEffectInfo Clone()
		{
			return new SpecialEffectInfo(this);
		}

		// Token: 0x06019174 RID: 102772 RVA: 0x003A68EE File Offset: 0x003A4AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialEffectInfo);
		}

		// Token: 0x06019175 RID: 102773 RVA: 0x003A68FC File Offset: 0x003A4AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialEffectInfo other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019176 RID: 102774 RVA: 0x003A691C File Offset: 0x003A4B1C
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

		// Token: 0x06019177 RID: 102775 RVA: 0x003A6942 File Offset: 0x003A4B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019178 RID: 102776 RVA: 0x003A694F File Offset: 0x003A4B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019179 RID: 102777 RVA: 0x003A6958 File Offset: 0x003A4B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601917A RID: 102778 RVA: 0x003A6970 File Offset: 0x003A4B70
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

		// Token: 0x0601917B RID: 102779 RVA: 0x003A6996 File Offset: 0x003A4B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialEffectInfo other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601917C RID: 102780 RVA: 0x003A69B3 File Offset: 0x003A4BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601917D RID: 102781 RVA: 0x003A69BC File Offset: 0x003A4BBC
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

		// Token: 0x040093C8 RID: 37832
		private UnknownFieldSet _unknownFields;
	}
}
