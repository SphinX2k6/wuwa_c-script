using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001176 RID: 4470
	public sealed class SceneItemSplineRuntimeData : IMessage<SceneItemSplineRuntimeData>, IMessage, IEquatable<SceneItemSplineRuntimeData>, IDeepCloneable<SceneItemSplineRuntimeData>, IBufferMessage
	{
		// Token: 0x06017D3F RID: 97599 RVA: 0x00375FD9 File Offset: 0x003741D9
		[NullableContext(1)]
		public static SceneItemSplineRuntimeData Create()
		{
			return new SceneItemSplineRuntimeData();
		}

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x06017D40 RID: 97600 RVA: 0x00375FE0 File Offset: 0x003741E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x06017D41 RID: 97601 RVA: 0x00375FE3 File Offset: 0x003741E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSplineRuntimeData.Descriptor;
			}
		}

		// Token: 0x06017D42 RID: 97602 RVA: 0x00375FEA File Offset: 0x003741EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData()
		{
		}

		// Token: 0x06017D43 RID: 97603 RVA: 0x00375FF4 File Offset: 0x003741F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData(SceneItemSplineRuntimeData other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.distanceAlongPath_ = other.distanceAlongPath_;
			this.curPos_ = ((other.curPos_ != null) ? other.curPos_.Clone() : null);
			this.curRot_ = ((other.curRot_ != null) ? other.curRot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D44 RID: 97604 RVA: 0x00376068 File Offset: 0x00374268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData Clone()
		{
			return new SceneItemSplineRuntimeData(this);
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x06017D45 RID: 97605 RVA: 0x00376070 File Offset: 0x00374270
		// (set) Token: 0x06017D46 RID: 97606 RVA: 0x00376088 File Offset: 0x00374288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DistanceAlongPath
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.distanceAlongPath_;
				}
				return SceneItemSplineRuntimeData.DistanceAlongPathDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.distanceAlongPath_ = value;
			}
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x06017D47 RID: 97607 RVA: 0x0037609F File Offset: 0x0037429F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDistanceAlongPath
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06017D48 RID: 97608 RVA: 0x003760AC File Offset: 0x003742AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDistanceAlongPath()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06017D49 RID: 97609 RVA: 0x003760BD File Offset: 0x003742BD
		// (set) Token: 0x06017D4A RID: 97610 RVA: 0x003760C5 File Offset: 0x003742C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector CurPos
		{
			get
			{
				return this.curPos_;
			}
			set
			{
				this.curPos_ = value;
			}
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06017D4B RID: 97611 RVA: 0x003760CE File Offset: 0x003742CE
		// (set) Token: 0x06017D4C RID: 97612 RVA: 0x003760D6 File Offset: 0x003742D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator CurRot
		{
			get
			{
				return this.curRot_;
			}
			set
			{
				this.curRot_ = value;
			}
		}

		// Token: 0x06017D4D RID: 97613 RVA: 0x003760DF File Offset: 0x003742DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSplineRuntimeData);
		}

		// Token: 0x06017D4E RID: 97614 RVA: 0x003760F0 File Offset: 0x003742F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSplineRuntimeData other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DistanceAlongPath, other.DistanceAlongPath) && object.Equals(this.CurPos, other.CurPos) && object.Equals(this.CurRot, other.CurRot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D4F RID: 97615 RVA: 0x00376160 File Offset: 0x00374360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasDistanceAlongPath)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DistanceAlongPath);
			}
			if (this.curPos_ != null)
			{
				num ^= this.CurPos.GetHashCode();
			}
			if (this.curRot_ != null)
			{
				num ^= this.CurRot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D50 RID: 97616 RVA: 0x003761CD File Offset: 0x003743CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D51 RID: 97617 RVA: 0x003761DA File Offset: 0x003743DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D52 RID: 97618 RVA: 0x003761E4 File Offset: 0x003743E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDistanceAlongPath)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.DistanceAlongPath);
			}
			if (this.curPos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CurPos);
			}
			if (this.curRot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CurRot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D53 RID: 97619 RVA: 0x0037625C File Offset: 0x0037445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasDistanceAlongPath)
			{
				num += 5;
			}
			if (this.curPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurPos);
			}
			if (this.curRot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurRot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D54 RID: 97620 RVA: 0x003762C0 File Offset: 0x003744C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSplineRuntimeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasDistanceAlongPath)
			{
				this.DistanceAlongPath = other.DistanceAlongPath;
			}
			if (other.curPos_ != null)
			{
				if (this.curPos_ == null)
				{
					this.CurPos = new Vector();
				}
				this.CurPos.MergeFrom(other.CurPos);
			}
			if (other.curRot_ != null)
			{
				if (this.curRot_ == null)
				{
					this.CurRot = new Rotator();
				}
				this.CurRot.MergeFrom(other.CurRot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D55 RID: 97621 RVA: 0x00376354 File Offset: 0x00374554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D56 RID: 97622 RVA: 0x00376360 File Offset: 0x00374560
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
				if (num != 13U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.curRot_ == null)
							{
								this.CurRot = new Rotator();
							}
							input.ReadMessage(this.CurRot);
						}
					}
					else
					{
						if (this.curPos_ == null)
						{
							this.CurPos = new Vector();
						}
						input.ReadMessage(this.CurPos);
					}
				}
				else
				{
					this.DistanceAlongPath = input.ReadFloat();
				}
			}
		}

		// Token: 0x04008D47 RID: 36167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D48 RID: 36168
		private int _hasBits0;

		// Token: 0x04008D49 RID: 36169
		public const int DistanceAlongPathFieldNumber = 1;

		// Token: 0x04008D4A RID: 36170
		private static readonly float DistanceAlongPathDefaultValue;

		// Token: 0x04008D4B RID: 36171
		private float distanceAlongPath_;

		// Token: 0x04008D4C RID: 36172
		public const int CurPosFieldNumber = 2;

		// Token: 0x04008D4D RID: 36173
		private Vector curPos_;

		// Token: 0x04008D4E RID: 36174
		public const int CurRotFieldNumber = 3;

		// Token: 0x04008D4F RID: 36175
		private Rotator curRot_;
	}
}
