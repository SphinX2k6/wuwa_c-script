using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B35 RID: 2869
	[NetMessage(EMessageId.NewTowerLastCycleInfoRequest)]
	public sealed class NewTowerLastCycleInfoRequest : IMessage<NewTowerLastCycleInfoRequest>, IMessage, IEquatable<NewTowerLastCycleInfoRequest>, IDeepCloneable<NewTowerLastCycleInfoRequest>, IBufferMessage
	{
		// Token: 0x0600F905 RID: 63749 RVA: 0x002452DD File Offset: 0x002434DD
		[NullableContext(1)]
		public static NewTowerLastCycleInfoRequest Create()
		{
			return new NewTowerLastCycleInfoRequest();
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600F906 RID: 63750 RVA: 0x002452E4 File Offset: 0x002434E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600F907 RID: 63751 RVA: 0x002452E7 File Offset: 0x002434E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLastCycleInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x002452EE File Offset: 0x002434EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest()
		{
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x002452F6 File Offset: 0x002434F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest(NewTowerLastCycleInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x0024530F File Offset: 0x0024350F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest Clone()
		{
			return new NewTowerLastCycleInfoRequest(this);
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x00245317 File Offset: 0x00243517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLastCycleInfoRequest);
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x00245325 File Offset: 0x00243525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLastCycleInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x00245344 File Offset: 0x00243544
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

		// Token: 0x0600F90E RID: 63758 RVA: 0x0024536A File Offset: 0x0024356A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x00245377 File Offset: 0x00243577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x00245380 File Offset: 0x00243580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x00245398 File Offset: 0x00243598
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

		// Token: 0x0600F912 RID: 63762 RVA: 0x002453BE File Offset: 0x002435BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLastCycleInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x002453DB File Offset: 0x002435DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x002453E4 File Offset: 0x002435E4
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

		// Token: 0x040063D6 RID: 25558
		private UnknownFieldSet _unknownFields;
	}
}
