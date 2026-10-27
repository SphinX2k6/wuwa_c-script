using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000632 RID: 1586
	[NetMessage(EMessageId.FormationSwitchCurrentRequest)]
	public sealed class FormationSwitchCurrentRequest : IMessage<FormationSwitchCurrentRequest>, IMessage, IEquatable<FormationSwitchCurrentRequest>, IDeepCloneable<FormationSwitchCurrentRequest>, IBufferMessage
	{
		// Token: 0x06009238 RID: 37432 RVA: 0x00161D6A File Offset: 0x0015FF6A
		[NullableContext(1)]
		public static FormationSwitchCurrentRequest Create()
		{
			return new FormationSwitchCurrentRequest();
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00161D71 File Offset: 0x0015FF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600923A RID: 37434 RVA: 0x00161D74 File Offset: 0x0015FF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchCurrentRequest.Descriptor;
			}
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00161D7B File Offset: 0x0015FF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest()
		{
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00161D83 File Offset: 0x0015FF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest(FormationSwitchCurrentRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00161DA8 File Offset: 0x0015FFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest Clone()
		{
			return new FormationSwitchCurrentRequest(this);
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600923E RID: 37438 RVA: 0x00161DB0 File Offset: 0x0015FFB0
		// (set) Token: 0x0600923F RID: 37439 RVA: 0x00161DB8 File Offset: 0x0015FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00161DC1 File Offset: 0x0015FFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchCurrentRequest);
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00161DCF File Offset: 0x0015FFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchCurrentRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00161E00 File Offset: 0x00160000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x00161E3F File Offset: 0x0016003F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00161E4C File Offset: 0x0016004C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00161E55 File Offset: 0x00160055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x00161E88 File Offset: 0x00160088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x00161EC6 File Offset: 0x001600C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchCurrentRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00161EF7 File Offset: 0x001600F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00161F00 File Offset: 0x00160100
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400468A RID: 18058
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400468B RID: 18059
		public const int IdFieldNumber = 2;

		// Token: 0x0400468C RID: 18060
		private int id_;
	}
}
