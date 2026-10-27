using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B52 RID: 2898
	[NetMessage(EMessageId.NewTowerUpdateRecordNotify)]
	public sealed class NewTowerUpdateRecordNotify : IMessage<NewTowerUpdateRecordNotify>, IMessage, IEquatable<NewTowerUpdateRecordNotify>, IDeepCloneable<NewTowerUpdateRecordNotify>, IBufferMessage
	{
		// Token: 0x0600FB43 RID: 64323 RVA: 0x00249D35 File Offset: 0x00247F35
		[NullableContext(1)]
		public static NewTowerUpdateRecordNotify Create()
		{
			return new NewTowerUpdateRecordNotify();
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600FB44 RID: 64324 RVA: 0x00249D3C File Offset: 0x00247F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600FB45 RID: 64325 RVA: 0x00249D3F File Offset: 0x00247F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordNotify.Descriptor;
			}
		}

		// Token: 0x0600FB46 RID: 64326 RVA: 0x00249D46 File Offset: 0x00247F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify()
		{
		}

		// Token: 0x0600FB47 RID: 64327 RVA: 0x00249D4E File Offset: 0x00247F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify(NewTowerUpdateRecordNotify other) : this()
		{
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB48 RID: 64328 RVA: 0x00249D83 File Offset: 0x00247F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify Clone()
		{
			return new NewTowerUpdateRecordNotify(this);
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600FB49 RID: 64329 RVA: 0x00249D8B File Offset: 0x00247F8B
		// (set) Token: 0x0600FB4A RID: 64330 RVA: 0x00249D93 File Offset: 0x00247F93
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

		// Token: 0x0600FB4B RID: 64331 RVA: 0x00249D9C File Offset: 0x00247F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordNotify);
		}

		// Token: 0x0600FB4C RID: 64332 RVA: 0x00249DAA File Offset: 0x00247FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB4D RID: 64333 RVA: 0x00249DE0 File Offset: 0x00247FE0
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

		// Token: 0x0600FB4E RID: 64334 RVA: 0x00249E1C File Offset: 0x0024801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB4F RID: 64335 RVA: 0x00249E29 File Offset: 0x00248029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB50 RID: 64336 RVA: 0x00249E32 File Offset: 0x00248032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.record_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Record);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB51 RID: 64337 RVA: 0x00249E64 File Offset: 0x00248064
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

		// Token: 0x0600FB52 RID: 64338 RVA: 0x00249EA4 File Offset: 0x002480A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordNotify other)
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

		// Token: 0x0600FB53 RID: 64339 RVA: 0x00249EF8 File Offset: 0x002480F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x00249F04 File Offset: 0x00248104
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
				if (num != 114U)
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

		// Token: 0x0400647A RID: 25722
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400647B RID: 25723
		public const int RecordFieldNumber = 14;

		// Token: 0x0400647C RID: 25724
		private NewTowerClimbingLevelRecord record_;
	}
}
