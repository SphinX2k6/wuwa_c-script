using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001567 RID: 5479
	[NetMessage(EMessageId.WeaponItemRequest)]
	public sealed class WeaponItemRequest : IMessage<WeaponItemRequest>, IMessage, IEquatable<WeaponItemRequest>, IDeepCloneable<WeaponItemRequest>, IBufferMessage
	{
		// Token: 0x0601D04E RID: 118862 RVA: 0x004342C1 File Offset: 0x004324C1
		[NullableContext(1)]
		public static WeaponItemRequest Create()
		{
			return new WeaponItemRequest();
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x0601D04F RID: 118863 RVA: 0x004342C8 File Offset: 0x004324C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x0601D050 RID: 118864 RVA: 0x004342CB File Offset: 0x004324CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemRequest.Descriptor;
			}
		}

		// Token: 0x0601D051 RID: 118865 RVA: 0x004342D2 File Offset: 0x004324D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest()
		{
		}

		// Token: 0x0601D052 RID: 118866 RVA: 0x004342DA File Offset: 0x004324DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest(WeaponItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D053 RID: 118867 RVA: 0x004342F3 File Offset: 0x004324F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest Clone()
		{
			return new WeaponItemRequest(this);
		}

		// Token: 0x0601D054 RID: 118868 RVA: 0x004342FB File Offset: 0x004324FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemRequest);
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x00434309 File Offset: 0x00432509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x00434328 File Offset: 0x00432528
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

		// Token: 0x0601D057 RID: 118871 RVA: 0x0043434E File Offset: 0x0043254E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D058 RID: 118872 RVA: 0x0043435B File Offset: 0x0043255B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x00434364 File Offset: 0x00432564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x0043437C File Offset: 0x0043257C
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

		// Token: 0x0601D05B RID: 118875 RVA: 0x004343A2 File Offset: 0x004325A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D05C RID: 118876 RVA: 0x004343BF File Offset: 0x004325BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D05D RID: 118877 RVA: 0x004343C8 File Offset: 0x004325C8
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

		// Token: 0x0400A6C1 RID: 42689
		private UnknownFieldSet _unknownFields;
	}
}
