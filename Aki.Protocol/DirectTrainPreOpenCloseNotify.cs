using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C6 RID: 966
	[NetMessage(EMessageId.DirectTrainPreOpenCloseNotify)]
	public sealed class DirectTrainPreOpenCloseNotify : IMessage<DirectTrainPreOpenCloseNotify>, IMessage, IEquatable<DirectTrainPreOpenCloseNotify>, IDeepCloneable<DirectTrainPreOpenCloseNotify>, IBufferMessage
	{
		// Token: 0x06005EB1 RID: 24241 RVA: 0x000E5B81 File Offset: 0x000E3D81
		[NullableContext(1)]
		public static DirectTrainPreOpenCloseNotify Create()
		{
			return new DirectTrainPreOpenCloseNotify();
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06005EB2 RID: 24242 RVA: 0x000E5B88 File Offset: 0x000E3D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x000E5B8B File Offset: 0x000E3D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainPreOpenCloseNotify.Descriptor;
			}
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x000E5B92 File Offset: 0x000E3D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify()
		{
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x000E5B9A File Offset: 0x000E3D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify(DirectTrainPreOpenCloseNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x000E5BBF File Offset: 0x000E3DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify Clone()
		{
			return new DirectTrainPreOpenCloseNotify(this);
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x000E5BC7 File Offset: 0x000E3DC7
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x000E5BCF File Offset: 0x000E3DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x000E5BD8 File Offset: 0x000E3DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainPreOpenCloseNotify);
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x000E5BE6 File Offset: 0x000E3DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainPreOpenCloseNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x000E5C14 File Offset: 0x000E3E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x000E5C53 File Offset: 0x000E3E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x000E5C60 File Offset: 0x000E3E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x000E5C69 File Offset: 0x000E3E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x000E5C9C File Offset: 0x000E3E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x000E5CDA File Offset: 0x000E3EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainPreOpenCloseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x000E5D0B File Offset: 0x000E3F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x000E5D14 File Offset: 0x000E3F14
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003744 RID: 14148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003745 RID: 14149
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04003746 RID: 14150
		private int activityId_;
	}
}
