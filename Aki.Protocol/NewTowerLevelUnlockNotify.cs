using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B27 RID: 2855
	[NetMessage(EMessageId.NewTowerLevelUnlockNotify)]
	public sealed class NewTowerLevelUnlockNotify : IMessage<NewTowerLevelUnlockNotify>, IMessage, IEquatable<NewTowerLevelUnlockNotify>, IDeepCloneable<NewTowerLevelUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600F824 RID: 63524 RVA: 0x002437B9 File Offset: 0x002419B9
		[NullableContext(1)]
		public static NewTowerLevelUnlockNotify Create()
		{
			return new NewTowerLevelUnlockNotify();
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600F825 RID: 63525 RVA: 0x002437C0 File Offset: 0x002419C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600F826 RID: 63526 RVA: 0x002437C3 File Offset: 0x002419C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLevelUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x002437CA File Offset: 0x002419CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify()
		{
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x002437D2 File Offset: 0x002419D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify(NewTowerLevelUnlockNotify other) : this()
		{
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F829 RID: 63529 RVA: 0x00243807 File Offset: 0x00241A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelUnlockNotify Clone()
		{
			return new NewTowerLevelUnlockNotify(this);
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600F82A RID: 63530 RVA: 0x0024380F File Offset: 0x00241A0F
		// (set) Token: 0x0600F82B RID: 63531 RVA: 0x00243817 File Offset: 0x00241A17
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

		// Token: 0x0600F82C RID: 63532 RVA: 0x00243820 File Offset: 0x00241A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLevelUnlockNotify);
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x0024382E File Offset: 0x00241A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLevelUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x00243864 File Offset: 0x00241A64
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

		// Token: 0x0600F82F RID: 63535 RVA: 0x002438A0 File Offset: 0x00241AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x002438AD File Offset: 0x00241AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x002438B6 File Offset: 0x00241AB6
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

		// Token: 0x0600F832 RID: 63538 RVA: 0x002438E8 File Offset: 0x00241AE8
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

		// Token: 0x0600F833 RID: 63539 RVA: 0x00243928 File Offset: 0x00241B28
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

		// Token: 0x0600F834 RID: 63540 RVA: 0x0024397C File Offset: 0x00241B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x00243988 File Offset: 0x00241B88
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

		// Token: 0x040063EC RID: 25580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063ED RID: 25581
		public const int RecordFieldNumber = 13;

		// Token: 0x040063EE RID: 25582
		private NewTowerClimbingLevelRecord record_;
	}
}
