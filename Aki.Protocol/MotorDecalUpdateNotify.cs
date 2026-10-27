using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2F RID: 2607
	[NetMessage(EMessageId.MotorDecalUpdateNotify)]
	public sealed class MotorDecalUpdateNotify : IMessage<MotorDecalUpdateNotify>, IMessage, IEquatable<MotorDecalUpdateNotify>, IDeepCloneable<MotorDecalUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E3C0 RID: 58304 RVA: 0x00215190 File Offset: 0x00213390
		[NullableContext(1)]
		public static MotorDecalUpdateNotify Create()
		{
			return new MotorDecalUpdateNotify();
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600E3C1 RID: 58305 RVA: 0x00215197 File Offset: 0x00213397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x0021519A File Offset: 0x0021339A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x002151A1 File Offset: 0x002133A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify()
		{
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x002151A9 File Offset: 0x002133A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify(MotorDecalUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x002151DE File Offset: 0x002133DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify Clone()
		{
			return new MotorDecalUpdateNotify(this);
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x002151E6 File Offset: 0x002133E6
		// (set) Token: 0x0600E3C7 RID: 58311 RVA: 0x002151EE File Offset: 0x002133EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x002151F7 File Offset: 0x002133F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalUpdateNotify);
		}

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x00215205 File Offset: 0x00213405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x00215238 File Offset: 0x00213438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3CB RID: 58315 RVA: 0x00215274 File Offset: 0x00213474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3CC RID: 58316 RVA: 0x00215281 File Offset: 0x00213481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3CD RID: 58317 RVA: 0x0021528A File Offset: 0x0021348A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x002152BC File Offset: 0x002134BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x002152FC File Offset: 0x002134FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x00215350 File Offset: 0x00213550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x0021535C File Offset: 0x0021355C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x04005D44 RID: 23876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D45 RID: 23877
		public const int TaskFieldNumber = 6;

		// Token: 0x04005D46 RID: 23878
		private ConditionTask task_;
	}
}
