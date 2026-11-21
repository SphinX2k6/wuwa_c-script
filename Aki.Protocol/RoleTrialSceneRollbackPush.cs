using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001106 RID: 4358
	[NetMessage(EMessageId.RoleTrialSceneRollbackPush)]
	public sealed class RoleTrialSceneRollbackPush : IMessage<RoleTrialSceneRollbackPush>, IMessage, IEquatable<RoleTrialSceneRollbackPush>, IDeepCloneable<RoleTrialSceneRollbackPush>, IBufferMessage
	{
		// Token: 0x060174BB RID: 95419 RVA: 0x00363EF0 File Offset: 0x003620F0
		[NullableContext(1)]
		public static RoleTrialSceneRollbackPush Create()
		{
			return new RoleTrialSceneRollbackPush();
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x060174BC RID: 95420 RVA: 0x00363EF7 File Offset: 0x003620F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x060174BD RID: 95421 RVA: 0x00363EFA File Offset: 0x003620FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialSceneRollbackPush.Descriptor;
			}
		}

		// Token: 0x060174BE RID: 95422 RVA: 0x00363F01 File Offset: 0x00362101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush()
		{
		}

		// Token: 0x060174BF RID: 95423 RVA: 0x00363F09 File Offset: 0x00362109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush(RoleTrialSceneRollbackPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174C0 RID: 95424 RVA: 0x00363F22 File Offset: 0x00362122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush Clone()
		{
			return new RoleTrialSceneRollbackPush(this);
		}

		// Token: 0x060174C1 RID: 95425 RVA: 0x00363F2A File Offset: 0x0036212A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialSceneRollbackPush);
		}

		// Token: 0x060174C2 RID: 95426 RVA: 0x00363F38 File Offset: 0x00362138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialSceneRollbackPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060174C3 RID: 95427 RVA: 0x00363F58 File Offset: 0x00362158
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

		// Token: 0x060174C4 RID: 95428 RVA: 0x00363F7E File Offset: 0x0036217E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174C5 RID: 95429 RVA: 0x00363F8B File Offset: 0x0036218B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174C6 RID: 95430 RVA: 0x00363F94 File Offset: 0x00362194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174C7 RID: 95431 RVA: 0x00363FAC File Offset: 0x003621AC
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

		// Token: 0x060174C8 RID: 95432 RVA: 0x00363FD2 File Offset: 0x003621D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialSceneRollbackPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174C9 RID: 95433 RVA: 0x00363FEF File Offset: 0x003621EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174CA RID: 95434 RVA: 0x00363FF8 File Offset: 0x003621F8
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

		// Token: 0x04008B48 RID: 35656
		private UnknownFieldSet _unknownFields;
	}
}
