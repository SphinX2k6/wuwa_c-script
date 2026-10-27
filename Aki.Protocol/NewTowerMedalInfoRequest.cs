using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3A RID: 2874
	[NetMessage(EMessageId.NewTowerMedalInfoRequest)]
	public sealed class NewTowerMedalInfoRequest : IMessage<NewTowerMedalInfoRequest>, IMessage, IEquatable<NewTowerMedalInfoRequest>, IDeepCloneable<NewTowerMedalInfoRequest>, IBufferMessage
	{
		// Token: 0x0600F96C RID: 63852 RVA: 0x002460BA File Offset: 0x002442BA
		[NullableContext(1)]
		public static NewTowerMedalInfoRequest Create()
		{
			return new NewTowerMedalInfoRequest();
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600F96D RID: 63853 RVA: 0x002460C1 File Offset: 0x002442C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600F96E RID: 63854 RVA: 0x002460C4 File Offset: 0x002442C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600F96F RID: 63855 RVA: 0x002460CB File Offset: 0x002442CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest()
		{
		}

		// Token: 0x0600F970 RID: 63856 RVA: 0x002460D3 File Offset: 0x002442D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest(NewTowerMedalInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F971 RID: 63857 RVA: 0x002460EC File Offset: 0x002442EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest Clone()
		{
			return new NewTowerMedalInfoRequest(this);
		}

		// Token: 0x0600F972 RID: 63858 RVA: 0x002460F4 File Offset: 0x002442F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfoRequest);
		}

		// Token: 0x0600F973 RID: 63859 RVA: 0x00246102 File Offset: 0x00244302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F974 RID: 63860 RVA: 0x00246120 File Offset: 0x00244320
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

		// Token: 0x0600F975 RID: 63861 RVA: 0x00246146 File Offset: 0x00244346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F976 RID: 63862 RVA: 0x00246153 File Offset: 0x00244353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F977 RID: 63863 RVA: 0x0024615C File Offset: 0x0024435C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F978 RID: 63864 RVA: 0x00246174 File Offset: 0x00244374
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

		// Token: 0x0600F979 RID: 63865 RVA: 0x0024619A File Offset: 0x0024439A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMedalInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F97A RID: 63866 RVA: 0x002461B7 File Offset: 0x002443B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F97B RID: 63867 RVA: 0x002461C0 File Offset: 0x002443C0
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

		// Token: 0x040063F2 RID: 25586
		private UnknownFieldSet _unknownFields;
	}
}
