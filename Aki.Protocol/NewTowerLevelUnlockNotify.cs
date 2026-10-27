using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B38 RID: 2872
	[NetMessage(EMessageId.NewTowerLevelUnlockNotify)]
	public sealed class NewTowerLevelUnlockNotify : IMessage<NewTowerLevelUnlockNotify>, IMessage, IEquatable<NewTowerLevelUnlockNotify>, IDeepCloneable<NewTowerLevelUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600F93E RID: 63806 RVA: 0x002459D5 File Offset: 0x00243BD5
		[NullableContext(1)]
		public static NewTowerLevelUnlockNotify Create()
		{
			return new NewTowerLevelUnlockNotify();
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600F93F RID: 63807 RVA: 0x002459DC File Offset: 0x00243BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600F940 RID: 63808 RVA: 0x002459DF File Offset: 0x00243BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLevelUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x002459E6 File Offset: 0x00243BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify()
		{
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x002459EE File Offset: 0x00243BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify(NewTowerLevelUnlockNotify other) : this()
		{
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F943 RID: 63811 RVA: 0x00245A23 File Offset: 0x00243C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify Clone()
		{
			return new NewTowerLevelUnlockNotify(this);
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600F944 RID: 63812 RVA: 0x00245A2B File Offset: 0x00243C2B
		// (set) Token: 0x0600F945 RID: 63813 RVA: 0x00245A33 File Offset: 0x00243C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x00245A3C File Offset: 0x00243C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLevelUnlockNotify);
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x00245A4A File Offset: 0x00243C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLevelUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F948 RID: 63816 RVA: 0x00245A80 File Offset: 0x00243C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.record_ != null)
			{
				num ^= this.Record.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F949 RID: 63817 RVA: 0x00245ABC File Offset: 0x00243CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F94A RID: 63818 RVA: 0x00245AC9 File Offset: 0x00243CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F94B RID: 63819 RVA: 0x00245AD2 File Offset: 0x00243CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.record_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Record);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F94C RID: 63820 RVA: 0x00245B04 File Offset: 0x00243D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.record_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Record);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F94D RID: 63821 RVA: 0x00245B44 File Offset: 0x00243D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLevelUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.record_ != null)
			{
				if (this.record_ == null)
				{
					this.Record = new NewTowerClimbingLevelRecord();
				}
				this.Record.MergeFrom(other.Record);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x00245B98 File Offset: 0x00243D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x00245BA4 File Offset: 0x00243DA4
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.record_ == null)
					{
						this.Record = new NewTowerClimbingLevelRecord();
					}
					input.ReadMessage(this.Record);
				}
			}
		}

		// Token: 0x040063E3 RID: 25571
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063E4 RID: 25572
		public const int RecordFieldNumber = 13;

		// Token: 0x040063E5 RID: 25573
		private NewTowerClimbingLevelRecord record_;
	}
}
