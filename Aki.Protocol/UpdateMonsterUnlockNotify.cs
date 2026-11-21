using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001510 RID: 5392
	[NetMessage(EMessageId.UpdateMonsterUnlockNotify)]
	public sealed class UpdateMonsterUnlockNotify : IMessage<UpdateMonsterUnlockNotify>, IMessage, IEquatable<UpdateMonsterUnlockNotify>, IDeepCloneable<UpdateMonsterUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601C91E RID: 117022 RVA: 0x00423F4F File Offset: 0x0042214F
		[NullableContext(1)]
		public static UpdateMonsterUnlockNotify Create()
		{
			return new UpdateMonsterUnlockNotify();
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x0601C91F RID: 117023 RVA: 0x00423F56 File Offset: 0x00422156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x0601C920 RID: 117024 RVA: 0x00423F59 File Offset: 0x00422159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMonsterUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601C921 RID: 117025 RVA: 0x00423F60 File Offset: 0x00422160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify()
		{
		}

		// Token: 0x0601C922 RID: 117026 RVA: 0x00423F68 File Offset: 0x00422168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify(UpdateMonsterUnlockNotify other) : this()
		{
			this.detectionUnlocks_ = ((other.detectionUnlocks_ != null) ? other.detectionUnlocks_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C923 RID: 117027 RVA: 0x00423F9D File Offset: 0x0042219D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify Clone()
		{
			return new UpdateMonsterUnlockNotify(this);
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x0601C924 RID: 117028 RVA: 0x00423FA5 File Offset: 0x004221A5
		// (set) Token: 0x0601C925 RID: 117029 RVA: 0x00423FAD File Offset: 0x004221AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock DetectionUnlocks
		{
			get
			{
				return this.detectionUnlocks_;
			}
			set
			{
				this.detectionUnlocks_ = value;
			}
		}

		// Token: 0x0601C926 RID: 117030 RVA: 0x00423FB6 File Offset: 0x004221B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMonsterUnlockNotify);
		}

		// Token: 0x0601C927 RID: 117031 RVA: 0x00423FC4 File Offset: 0x004221C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMonsterUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.DetectionUnlocks, other.DetectionUnlocks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C928 RID: 117032 RVA: 0x00423FF8 File Offset: 0x004221F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.detectionUnlocks_ != null)
			{
				num ^= this.DetectionUnlocks.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C929 RID: 117033 RVA: 0x00424034 File Offset: 0x00422234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C92A RID: 117034 RVA: 0x00424041 File Offset: 0x00422241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C92B RID: 117035 RVA: 0x0042404A File Offset: 0x0042224A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.detectionUnlocks_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DetectionUnlocks);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C92C RID: 117036 RVA: 0x0042407C File Offset: 0x0042227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.detectionUnlocks_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetectionUnlocks);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C92D RID: 117037 RVA: 0x004240BC File Offset: 0x004222BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMonsterUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.detectionUnlocks_ != null)
			{
				if (this.detectionUnlocks_ == null)
				{
					this.DetectionUnlocks = new DetectionUnlock();
				}
				this.DetectionUnlocks.MergeFrom(other.DetectionUnlocks);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C92E RID: 117038 RVA: 0x00424110 File Offset: 0x00422310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C92F RID: 117039 RVA: 0x0042411C File Offset: 0x0042231C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.detectionUnlocks_ == null)
					{
						this.DetectionUnlocks = new DetectionUnlock();
					}
					input.ReadMessage(this.DetectionUnlocks);
				}
			}
		}

		// Token: 0x0400A4AE RID: 42158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4AF RID: 42159
		public const int DetectionUnlocksFieldNumber = 12;

		// Token: 0x0400A4B0 RID: 42160
		private DetectionUnlock detectionUnlocks_;
	}
}
