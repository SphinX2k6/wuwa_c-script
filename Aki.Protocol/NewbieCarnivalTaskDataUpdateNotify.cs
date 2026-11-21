using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF4 RID: 2804
	[NetMessage(EMessageId.NewbieCarnivalTaskDataUpdateNotify)]
	public sealed class NewbieCarnivalTaskDataUpdateNotify : IMessage<NewbieCarnivalTaskDataUpdateNotify>, IMessage, IEquatable<NewbieCarnivalTaskDataUpdateNotify>, IDeepCloneable<NewbieCarnivalTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F411 RID: 62481 RVA: 0x0023A601 File Offset: 0x00238801
		[NullableContext(1)]
		public static NewbieCarnivalTaskDataUpdateNotify Create()
		{
			return new NewbieCarnivalTaskDataUpdateNotify();
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600F412 RID: 62482 RVA: 0x0023A608 File Offset: 0x00238808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600F413 RID: 62483 RVA: 0x0023A60B File Offset: 0x0023880B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F414 RID: 62484 RVA: 0x0023A612 File Offset: 0x00238812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600F415 RID: 62485 RVA: 0x0023A61A File Offset: 0x0023881A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify(NewbieCarnivalTaskDataUpdateNotify other) : this()
		{
			this.activityTaskData_ = ((other.activityTaskData_ != null) ? other.activityTaskData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F416 RID: 62486 RVA: 0x0023A64F File Offset: 0x0023884F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalTaskDataUpdateNotify Clone()
		{
			return new NewbieCarnivalTaskDataUpdateNotify(this);
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600F417 RID: 62487 RVA: 0x0023A657 File Offset: 0x00238857
		// (set) Token: 0x0600F418 RID: 62488 RVA: 0x0023A65F File Offset: 0x0023885F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskData
		{
			get
			{
				return this.activityTaskData_;
			}
			set
			{
				this.activityTaskData_ = value;
			}
		}

		// Token: 0x0600F419 RID: 62489 RVA: 0x0023A668 File Offset: 0x00238868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalTaskDataUpdateNotify);
		}

		// Token: 0x0600F41A RID: 62490 RVA: 0x0023A676 File Offset: 0x00238876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskData, other.ActivityTaskData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F41B RID: 62491 RVA: 0x0023A6AC File Offset: 0x002388AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTaskData_ != null)
			{
				num ^= this.ActivityTaskData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F41C RID: 62492 RVA: 0x0023A6E8 File Offset: 0x002388E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F41D RID: 62493 RVA: 0x0023A6F5 File Offset: 0x002388F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F41E RID: 62494 RVA: 0x0023A6FE File Offset: 0x002388FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTaskData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F41F RID: 62495 RVA: 0x0023A730 File Offset: 0x00238930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F420 RID: 62496 RVA: 0x0023A770 File Offset: 0x00238970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalTaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTaskData_ != null)
			{
				if (this.activityTaskData_ == null)
				{
					this.ActivityTaskData = new ActivityTaskData();
				}
				this.ActivityTaskData.MergeFrom(other.ActivityTaskData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F421 RID: 62497 RVA: 0x0023A7C4 File Offset: 0x002389C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F422 RID: 62498 RVA: 0x0023A7D0 File Offset: 0x002389D0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityTaskData_ == null)
					{
						this.ActivityTaskData = new ActivityTaskData();
					}
					input.ReadMessage(this.ActivityTaskData);
				}
			}
		}

		// Token: 0x040062AB RID: 25259
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062AC RID: 25260
		public const int ActivityTaskDataFieldNumber = 9;

		// Token: 0x040062AD RID: 25261
		private ActivityTaskData activityTaskData_;
	}
}
